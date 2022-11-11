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
    class Cylinder : Shape
    {
        protected double radius;
        protected double height;
      
        public Cylinder()
        {
            this.Type = "Cylinder";
            SetData();
        }

        // Asking user to enter radius and height and will show an error message if worng data entered
        public override void SetData()
        {
            try
            {
                Console.WriteLine("Enter the radius: ");
                radius = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the height: ");
                height = double.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Inavild data entered......."+e.Message);
            }
        }
        
         
         // Formula to get the area of the cylinder
        public override double CalculateArea()
        {
            return (2 * Shape.PI * Math.Pow(radius, 2) * height);
        }


        ///Formula to get the volume of the cylinder 
        public override double CalculateVolume()
        {
            return Shape.PI * Math.Pow(radius, 2) * height;
        }
        
        public override string ToString()
        {
            return string.Format("{0:C11}{1,24:F2}{2,16:f2}{3,6:f2} r x {4,4:f2} h", base.Type, CalculateArea(), CalculateVolume(), radius, height);
        }
    }
}
