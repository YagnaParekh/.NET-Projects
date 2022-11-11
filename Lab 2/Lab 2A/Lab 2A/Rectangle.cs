/*
 * I, Yagna Parekh, 000846481 certify that this material is my original work. 
 * No other person's work has been used without due acknowledgement. 
 * 
 * This is Rectangle.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2A
{
    class Rectangle : Shape
    {
        protected double length { get; set; }
        protected double width { get; set; }

        /// <summary>
        /// Get and Set method for length and width for rectangle
        /// </summary>
        /// <returns> It returns length and width </returns>

        public Rectangle()
        {
            this.Type = "Rectangle";
            SetData();
        }
   

        /// Method to get the area of rectangle
        public override double CalculateArea()
        {
            return length * width;
        }

        
        /// <summary>
        /// Override method to calcuate volume 
        /// </summary>
        /// <returns> volume of rectangle </returns>
        public override double CalculateVolume()
        {
            return 0.0;
        }


        /// <summary>
        /// Prompt the user for the required data, lenght and width
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.Write("Enter the length of rectangle: ");
                length = double.Parse(Console.ReadLine());

                Console.Write("Enter the width of rectangle: ");
                width = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid data entered........");// It shows invalid message if something unexpected has been inputed.
            }
        }

        
        public override string ToString()
        {
            return string.Format("{0:C11}{1,23:F2}{2,22:F2}1 x {3:F2} w", base.Type, CalculateArea(), length, width);
        }
    }
}
