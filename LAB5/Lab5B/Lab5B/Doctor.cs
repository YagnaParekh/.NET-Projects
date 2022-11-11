using System.Drawing;


/*
 * 
 * I, Yagna Parekh, 000846481 certify that this material is my original work.  
 * * No other person's work has been used without due acknowledgement.
 */
namespace Lab5B
{
    class Doctor
    {
        public int ID { get; set; }
        public string Actor { get; set; }
        public int Series { get; set; }
        public int Age { get; set; }
        public string Debut { get; set; }
        public Image Picture { get; set; }

        /// <summary>
        /// Enter new Data of Doctor
        /// </summary>
        /// <param name="id">id of doctor</param>
        /// <param name="actor">name of actor</param>
        /// <param name="series">series name</param>
        /// <param name="age">age of doctor</param>
        /// <param name="debut">debut of doctor</param>
        /// <param name="pic">picture of doctor</param>
        public Doctor(int id, string actor, int series, int age, string debut, Image pic)
        {
            ID = id;
            Actor = actor;
            Series = series;
            Age = age;
            Debut = debut;
            Picture = pic;
        }
    }
}
