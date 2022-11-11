/*
 * I, Yagna Parekh, 000846481 certify that this material is my original work. 
 * No other person's work has been used without due acknowledgement. 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2A
{
    class Cube : Shape
    {
        protected double length { get; set; }

        public Cube()
        {
            this.Type = "Cube";
            SetData();
        }

        /// <summary>
        /// Ask the user to enter the lenght of cube
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.WriteLine("Enter the length: ");
                length = double.Parse(Console.ReadLine());
            }
            catch(Exception e)// Inavalid message for wrong data
            {
                Console.WriteLine("Invalid data entered......" + e.Message);
            }
        }


        /// <summary>
        /// Formula to get area of the cube
        /// </summary>
        /// <returns> Area of Cube</returns>
        public override double CalculateArea()
        {
            return 6 * Math.Pow(length, 2);
        }


        /// <summary>
        /// Formula to get Volume of the cube
        /// </summary>
        /// <returns> Area of the cube</returns>
        public override double CalculateVolume()
        {
            return Math.Pow(length, 3);
        }

        /// <summary>
        /// String method to get the all information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0:C11}{1,28:F2}{2,16:F2}{3,6:F2} 1", base.Type, CalculateArea(), CalculateVolume(), length);
        }
    }
}
