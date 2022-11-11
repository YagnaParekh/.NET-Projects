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
    class Eclipse : Shape
    {
        protected double semi_axis_a;
        protected double semi_axis_b;
        protected double semi_axis_c;

        public Eclipse()
        {
            this.Type = "Eclipse";
            SetData();
        }

        // Get the area of eclipse
        public override double CalculateArea()
        {
            return (Shape.PI * semi_axis_a * semi_axis_b);
        }


        // Get the volume of eclipse
        public override double CalculateVolume()
        {
            return (Shape.PI * semi_axis_a * semi_axis_b * semi_axis_c);
        }

        // Set data to ask the user for semi axis radius a, b and c 
        public override void SetData()
        {
            try
            {
                Console.WriteLine("Enter the semi axis radius A: ");
                semi_axis_a = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the semi axis radius B: ");
                semi_axis_b = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the semi axis radius C :");
                semi_axis_c = double.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid data entered........"+ e.Message);
            }
        }


        public override string ToString()
        {
            return string.Format("{0:C11}{1,25:F2}{2,22:F2} s.major x {3,5:F2} s.minor x {4,7:F2}", base.Type, CalculateArea(),semi_axis_a, semi_axis_b, semi_axis_c);
        }
    }
}
