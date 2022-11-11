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
    class Box : Rectangle
    {
        protected double height { get; set; }

        public Box()
        {
            this.Type = "Box";
            SetData();
        }

        /// <summary>
        /// Set data for box and will get inherited it from rectangle
        /// </summary>
        public override void SetData()
        { 
            base.SetData();// will get the data from rectangle
        }

        /// <summary>
        /// Will get the area of the box
        /// </summary>
        /// <returns> Area of Box </returns>
        public override double CalculateArea()
        {
            return (2 * length * width) + (2 * length * height) + (2 * width * height);/
        }

        /// <summary>
        /// Will calculate volume of the box
        /// </summary>
        /// <returns> Volume of Box </returns>
        public override double CalculateVolume()
        {
            return base.CalculateVolume() * length;
        }

        /// <summary>
        /// To string method from the class rectangle
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
