/*
 * I Yagna Parekh , 000846481 certify that this material is my original work. 
 * No other person's work has been used without due acknowledgement.
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_000846481
{
    public class Employee
    {
        string name;
        int number;
        decimal rate, gross;
        double hours;

        /// <summary>
        /// Appropriate Constructors fot the class Employee 
        ///
        /// </summary>
        /// <param name="name"> Employee's Name</param>
        /// <param name="number">Employee's Number</param>
        /// <param name="rate">Employee's Rate</param>
        /// <param name="hours">Employee's Hours</param>
        public Employee(string name, int number, decimal rate, double hours)
        {
            this.name = name;
            this.number = number;
            this.rate = rate;
            this.hours = hours;
            this.gross = (decimal)this.hours * this.rate;
        }

        /// <summary>
        /// Gross pay of an employee
        /// </summary>
        /// <returns>Gross pay</returns>
        public decimal getGross()
        {
            gross =  (decimal) this.hours * this.rate;
            return (decimal)gross;
        }

        /// <summary>
        /// Hours worked
        /// </summary>
        /// <returns> Hours </returns>
        public double GetHours()
        {
            return this.hours;
        }

        /// <summary>
        /// Name of every employee
        /// </summary>
        /// <returns> Name </returns>
        public string GetName()
        {
            return this.name;
        }

        /// <summary>
        /// Unique Number assigned
        /// </summary>
        /// <returns> Number </returns>
        public int GetNum()
        {
            return this.number;
        }

        /// <summary>
        /// Pay Rate of every employee
        /// </summary>
        /// <returns> Pay Rate </returns>
        public decimal GetRate()
        {
            return this.rate;
        }
        public override string ToString()
        {
            return String.Format($"{name}, \t{number}, \t{"$"+rate},\t{hours},\t{"$"+getGross()}");
        }

        /// <summary>
        /// Set the pay rate of employees
        /// </summary>
        /// <param name="rate"> Pay Rate </param>
        public void setRate(decimal rate)
        {
            rate = this.rate;
            gross = (decimal)hours * this.rate;
        }

        /// <summary>
        /// Set the name of employee
        /// </summary>
        /// <param name="name"> Name </param>
        public void setName(string name)
        {
            name = this.name;
        }

        /// <summary>
        /// Assign working hours
        /// </summary>
        /// <param name="hours"> Hours </param>
        public void setHours(double hours)
        {
            hours = this.hours;
            gross = (decimal)this.hours * rate;
        }

        /// <summary>
        /// Employee Number
        /// </summary>
        /// <param name="number"> Number </param>
        public void setNumbers(int number)
        {
            this.number = number;
        }
    }
}
