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
    class Circle: Shape
    {
        protected double radius { get; set; }

        public Circle()
        {
            this.Type = "Circle";
            SetData();
        }

        /// <summary>
        /// Formula to calculate area of the circle
        /// </summary>
        /// <returns> Area of the circle </returns>
        
        public override double CalculateArea()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }


        /// <summary>
        /// There is no volume of circle
        /// </summary>
        /// <returns> It returns nothing</returns>
        public override double CalculateVolume()
        {
            return 0;
        }

        /// <summary>
        /// Set data to propmt user for the radius 
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.WriteLine("Enter circle radius: ");
                radius = double.Parse(Console.ReadLine());
            }
            catch(Exception e)// Error message if false data has been entered
            {
                Console.WriteLine("Invalid data inserted......"+e.Message);
            }
        }
        public override string ToString()
        {
            return string.Format("{0:C10}{1,26:F2}{2, 22:f2} r", base.Type, CalculateArea(), radius);
        }
    }
}

