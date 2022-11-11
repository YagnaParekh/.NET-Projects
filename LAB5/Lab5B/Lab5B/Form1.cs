using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

/*
 * 
 * I, Yagna Parekh, 000846481 certify that this material is my original work.  
 * * No other person's work has been used without due acknowledgement.
 */


namespace Lab5B
{
    public partial class Form1 : Form
    {
        public SqlConnection Connection { get; }
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=COMP10204_Lab5;Integrated Security=True";
        List<Doctor> doctor = new List<Doctor>();
        List<Companion> companion = new List<Companion>();
        List<Episode> episode = new List<Episode>();
        public Form1()
        {
            InitializeComponent();

            try
            {
                Connection = new SqlConnection();
                Connection.ConnectionString = connectionString;
                Connection.Open();
                statusLBL.Text = "Database has been connected successfully";
            }
            catch(Exception e)
            {
                statusLBL.Text = $"Database Connection Failed - Check Connection String: {e.Message}";
            }
        }


        /// <summary>
        /// This program will be executed when the the form has loaded for first time,
        /// then it will run the sql query for doctor, episodes and companions
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Select everythin from he episodes
            SqlCommand command = new SqlCommand("SELECT * FROM EPISODE", Connection);
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                string storyid = (string)reader["STORYID"];
                int season = (int)reader["SEASON"];
                int seasonYear = (int)reader["SEASONYEAR"];
                string title = (string)reader["TITLE"];

                episode.Add(new Episode(storyid, season, seasonYear, title));
            }
            reader.Close();

            // Getting everything from companion
             command = new SqlCommand("SELECT * FROM COMPANION", Connection);
             reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = (string)reader["NAME"];
                string actor = (string)reader["ACTOR"];
                int doctorId = (int)reader["DOCTORID"];
                string storyId = (string)reader["STORYID"];

                companion.Add(new Companion(name, actor, doctorId, storyId));
            }
            reader.Close();


            // Fetching all data from Doctor table
            command = new SqlCommand("SELECT * FROM DOCTOR", Connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                int doctorId = (int)reader["DOCTORID"];
                string actor = (string)reader["ACTOR"];
                int series = (int)reader["SERIES"];
                int age = (int)reader["AGE"];
                string debut = (string)reader["DEBUT"];
                byte[] image = (byte[])reader["PICTURES"];

                MemoryStream stream = new MemoryStream(image);
                Image picture = Image.FromStream(stream);

                doctor.Add(new Doctor(doctorId, actor, series, age, debut, picture));
            }
            reader.Close();


            foreach(Doctor doctors in doctor)
            {
                doctorCB.Items.Add(doctors.ID);
            }
            doctorCB.SelectedIndex = 0;

            if(sqlRB.Checked)
            {
                LoadUsingSQL();
            }
            else
            {
                LoadUsingLINQ();
            }
        }

        /// <summary>
        /// This method is for executing all the SQL queries
        /// </summary>

        private void LoadUsingSQL()
        {
            int doctorId = doctorCB.SelectedIndex + 1;
            SqlCommand command = new SqlCommand(@"
            SELECT * FROM DOCTOR d 
            JOIN EPISODE e
            ON d.DEBUT = e.STORYID
            WHERE d.DOCTORID = @doctorId
            ", Connection);


            SqlParameter param = new SqlParameter("@doctorid", SqlDbType.Int);
            command.Parameters.Add(param);
            param.Value = doctorId;
            SqlDataReader reader = command.ExecuteReader();


            if(reader.HasRows)
            {
                reader.Read();
                playerTB.Text = (string)reader["ACTOR"];
                yearTB.Text = ((int)reader["SEASONYEAR"]).ToString();
                seriesTB.Text = ((int)reader["SERIES"]).ToString();
                ageTB.Text = ((int)reader["AGE"]).ToString();
                firstEpisodeTB.Text = (string)reader["TITLE"];

                byte[] image = (byte[])reader["PICTURES"];

                MemoryStream stream = new MemoryStream(image);
                Image picture = Image.FromStream(stream);
                imagePB.Image = Image.FromStream(stream);
            }
            else
            {
                playerTB.Clear();
                yearTB.Clear();
                seriesTB.Clear();
                ageTB.Clear();
                firstEpisodeTB.Clear();
                imagePB.Image = null;
                statusLBL.Text = "Failed to load Doctors";
            }
            reader.Close();

            SqlCommand command2 = new SqlCommand(@"
            SELECT * FROM COMPANION c 
            JOIN EPISODE e
            ON c.STORYID = e.STORYID
            WHERE c.DOCTORID = @doctorId
            ORDER BY e.SEASONYEAR
            ", Connection);

            SqlParameter param2 = new SqlParameter("@doctorid", SqlDbType.Int);
            command2.Parameters.Add(param2);
            param2.Value = doctorId;
            reader = command2.ExecuteReader();

            companionLB.Items.Clear();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    string name = (string)reader["NAME"];
                    string actor = (string)reader["ACTOR"];
                    string title = (string)reader["TITLE"];
                    int year = (int)reader["SEASONYEAR"];
                }
            }
            else
            {
                statusLBL.Text = "Failed to load Companions";
            }
            reader.Close();
        }


        /// <summary>
        /// This method is for running all data using list 
        /// </summary>
        private void LoadUsingLINQ() 
        {
            int doctorID = doctorCB.SelectedIndex + 1;
            var doctorResults =
                from doctors in doctor
                join episodes in episode
                on doctors.Debut equals episodes.StoryID
                where doctors.ID == doctorID
                select new
                {
                    doctors,
                    episodes
                    
                };
            var result = doctorResults.First();
            if(doctorResults.Count() > 0)
            {
                playerTB.Text = result.doctors.Actor.ToString();
                yearTB.Text = result.episodes.Season_Year.ToString();
                seriesTB.Text = result.doctors.Series.ToString();
                ageTB.Text = result.doctors.Age.ToString();
                firstEpisodeTB.Text = result.episodes.Title;
                imagePB.Image = result.doctors.Picture;
            }
            else
            {
                playerTB.Clear();
                yearTB.Clear();
                seriesTB.Clear();
                ageTB.Clear();
                firstEpisodeTB.Clear();
                imagePB.Image = null;
                statusLBL.Text = "Failed to load Doctors";
            }
            companionLB.Items.Clear();
            var companionResults =
                from companions in companion
                join episodes in episode
                on companions.Story_ID equals episodes.StoryID
                where companions.Doctor_ID == doctorID
                orderby episodes.StoryID
                select new
                {
                    companions,
                    episodes
                };
            if(companionResults.Count() >= 1)
            {
                foreach(var comp in companionResults)
                {
                    companionLB.Items.Add($"{comp.companions.Name} ({comp.companions.Actor})");
                    companionLB.Items.Add($"{comp.episodes.Title} ({comp.episodes.Season_Year})");
                    companionLB.Items.Add("");
                }
            }
        }







        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// It will have two option if you select SQL then the method of executing 
        /// SQL queries will be runiing otherwise method of LINQ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doctorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sqlRB.Checked)
            {
                LoadUsingSQL();

            }
            else
            {
                LoadUsingLINQ();
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
