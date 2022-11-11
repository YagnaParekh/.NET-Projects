using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//I, Yagna Parekh, 000846481 certify that this material is my original work.

//No other person's work has been used without due acknowledgement.


namespace Lab3B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add hair dresser to combo-box
            hair_dresser_combobox.Items.Add("Jane Samley");
            hair_dresser_combobox.Items.Add("Pat");
            hair_dresser_combobox.Items.Add("Ron");
            hair_dresser_combobox.Items.Add("Sue");
            hair_dresser_combobox.Items.Add("Laurie");


            // Adding services to the list box
            services_listbox.Items.Add("Cut");
            services_listbox.Items.Add("Wash, blow-dry, and style");
            services_listbox.Items.Add("Colour");
            services_listbox.Items.Add("Highlights");
            services_listbox.Items.Add("Up-Do");


            hair_dresser_combobox.SelectedIndex = 0; // Jane Samley already selected
            hair_dresser_combobox.Focus();
            Calculate_button.Enabled = false; // Cannot calculate until the selection of hair-dresser and services
            add_service_button.Enabled = true;
            charged_listbox.SelectionMode = 0;
            price_listbox.SelectionMode = 0;
        }

        // Method to get the prices respective hair-dresser
        private decimal getHair_Dresser()
        {

            string hair_dresser = hair_dresser_combobox.SelectedItem.ToString();

            if (hair_dresser == "Jane Samley")
                return 30;// $30.00 
            if (hair_dresser == "Pat")
                return 45;// $45.00
            if (hair_dresser == "Ron")
                return 40;// $40.00 
            if (hair_dresser == "Sue")
                return 50;// $50.00 
            if (hair_dresser == "Laurie")
                return 55;// $55.00 
            else
                return 0;
        }

        // Get the prices of all repective services
        private decimal getServices()
        {
            string services = services_listbox.SelectedItem.ToString();

            if (services == "Cut")
                return 30;//$30.00
            if (services == "Wash, blow-dry, and style")
                return 20;// $20.00 
            if (services == "Colour")
                return 40;// $40.00 
            if (services == "Highlights")
                return 200;// $200.00 
            if (services == "Up-Do")
                return 60;// $60.00 
            else
                return 0;
        }

       
        private void add_service_button_Click(object sender, EventArgs e)
        {
            if(hair_dresser_combobox.Enabled)
            {
                charged_listbox.Items.Add(hair_dresser_combobox.SelectedItem.ToString());
                price_listbox.Items.Add(getHair_Dresser().ToString("$0.00"));
                hair_dresser_combobox.Enabled = false; // Once hair-dresser selected cannot be changed 
                Calculate_button.Enabled = true;
            }

            charged_listbox.Items.Add(services_listbox.SelectedItem.ToString());
            price_listbox.Items.Add(getServices().ToString("$0.00")); //Coverting to string
            services_listbox.SelectedItem = null;

            add_service_button.Enabled = true;
        }

        private void service_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_service_button.Enabled = true;
        }

        // Method to calculate the total price of all services and a hair-dresser
        private void Calculate_button_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (string price in price_listbox.Items)
            {
                if (decimal.TryParse(price.Remove(0, 1), out decimal priceitems) == false)
                    MessageBox.Show("Error converting " + price + "into decimal");
                else
                    total += priceitems;

                total_price_textbox.Text = total.ToString("$0.00");
            }
        }

        // Method to reset everything 
        private void reset_button_Click(object sender, EventArgs e)
        {
            hair_dresser_combobox.SelectedIndex = 0;
            hair_dresser_combobox.Focus();
            hair_dresser_combobox.Enabled = true;

            Calculate_button.Enabled = false;
            add_service_button.Enabled = false;

            charged_listbox.Items.Clear();
            price_listbox.Items.Clear();
            total_price_textbox.Clear();
        }

        // To stop the application
        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hair_dresser_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
