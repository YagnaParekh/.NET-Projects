/*
 * I, Yagna Parekh, 000846481 certify that this material is my original work. 
 * No other person's work has been used without due acknowledgement. 
 * 
 * This is Tetrahron class.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2A
{
    class Tetrahedron :Shape
    {
        protected double length;

        /// <summary>
        /// Constructor of Tetrahedron
        /// </summary>
        public Tetrahedron()
        {
            this.Type = "Tetrahdron";
            SetData();
        }


        /// <summary>
        /// Area of Tetrahedron
        /// </summary>
        /// <returns> tetrahedron area</returns>
        public override double CalculateArea()
        {
            return ( (Math.Sqrt(3)) * Math.Pow(length, 2) );
        }


        /// <summary>
        /// Volume of Tetrahedron
        /// </summary>
        /// <returns> tetrahedron volume </returns>
        public override double CalculateVolume()
        {
            return ( Math.Pow(length, 3)) / (6 * (Math.Sqrt(2)) );
        }


        /// <summary>
        /// Propmt user for length
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.WriteLine("Enter the length :");
                length = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid entry of data...."+ e.Message);
            }
        }

        public override string ToString()
        {
            return string.Format("{0:C11}{1,21:F2}{2,16,F2}{3,5:F2} 1", base.Type, CalculateArea(), CalculateVolume(), length);
        }
    }
}
