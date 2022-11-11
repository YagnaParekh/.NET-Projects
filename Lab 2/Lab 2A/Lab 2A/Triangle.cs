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
    class Triangle : Shape
    {
        protected double triangle_base;
        protected double triangle_height;

        public Triangle()
        {
            this.Type = "Triangle";
            SetData();
        }

        // get the area fo the triangle from height and base
        public override double CalculateArea()
        {
            return (1 / 2) * triangle_base * triangle_height;
        }

        // no volume of traingle......
        public override double CalculateVolume()
        {
            return 0.0;
        }


        // Propmt the user to enetr valid values of height and base
        public override void SetData()
        {
            try
            {
                Console.WriteLine("Enter the base of triangle : ");
                triangle_base = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the height of traingle :");
                triangle_height = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid data entered...." + e.Message);
            }
        }


        public override string ToString()
        {
            return string.Format("{0:C11}{1,24:F2}{2,22:F2} b x {3,4:F2} h", base.Type, CalculateArea(), triangle_base, triangle_height);
        }
    }
}
