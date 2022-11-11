using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2A
{
    class Sphere : Shape
    {
        protected double radius { get; set; }

        /// <summary>
        /// Method for volume
        /// </summary>
        /// <returns> volume</returns>
        
        public Sphere()
        {
            this.Type = "Sphere";
            SetData();
        }
        public override double CalculateVolume()
        {
            return ( (4 / 3) * Shape.PI * Math.Pow(radius, 2) );
        }


        /// <summary>
        /// Area of circle
        /// </summary>
        /// <returns> area </returns>
        public override double CalculateArea()
        {
            return 4 * Shape.PI * Math.Pow(radius, 2);
        }


        /// <summary>
        /// Sets data to ask user for input data (radius of circle)
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.WriteLine("Enter radius of circle : ");
                radius = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid entry of data radius........"+e.Message);
            }
        }


        public override string ToString()
        {
            return string.Format("{0:C11}{1,26:F2}{2,16:F2}{3,6:F2}r ", base.Type, CalculateArea(), CalculateVolume(), radius);
        }
    }
}
