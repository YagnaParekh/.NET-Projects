/*
 * I, Yagna Parekh, 000846481 certify that this material is my original work. 
 * No other person's work has been used without due acknowledgement. 
 * 
 * This is Shape class.
 */


using Lab_2A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_2A
{
    class Square : Shape
    {
        protected double length { get; set; }

        /// <summary>
        /// Override method to get the area of the square
        /// </summary>
        /// <returns> lenght * length </returns>
        
        public Square()
        {
            this.Type = "Square";
            SetData();
        }
        public override double CalculateArea()
        {
            return length * length;
        }

        /// <summary>
        /// Method for Volume
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume()
        {
            return 0.0;
        }


        /// <summary>
        /// Asks the user to to prompt the data to calculate area and volume.
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.WriteLine("Enter the Square Length: ");
                length = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Data entry........" + e.Message);
            }
        }

        public override string ToString()
        {
            return string.Format("{0:C11}{1,26:F2}{2,22:f2}1 ", base.Type, CalculateArea(), length);
        }
    }
}
