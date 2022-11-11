/*
 * Yagna Parekh
 * November 21, 2021
 * 
 * 
 * 
 * I, Yagna Parekh, 000846481 certify this material is my original work.
 * No other person's work has been used without due acknowledgement.
 */


using System;
using System.Collections;
using System.Collections.Generic;


namespace Lab4A
{
    class Employee : IComparable<Employee>
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public decimal Rate { get; set; }
        public double Hours { get; set; }
        public decimal Gross { get; set; }

        /// <summary>
        /// Main Constructor of Employee
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="num">Number</param>
        /// <param name="rate">Rate</param>
        /// <param name="hours">HOurs</param>
        public Employee(string name, int num, decimal rate, double hours)
        {
            Name = name;
            Number = num;
            Rate = rate;
            Hours = hours;
            Gross = (decimal)Hours * Rate;

            if (hours > 40)
                Gross = Gross + (((decimal)Hours - 40) * Rate * (decimal)0.5);
        }

        /// <summary>
        /// string of Employee
        /// </summary>
        /// <returns>Employee String</returns>
        public override string ToString()
        {
            return $"{Name,-20}   {Number,-5}  {Rate,-6:$0.00}  {Hours,-5:0.00}   {Gross,9:0,0.00}";
        }

        /// <summary>
        /// Comparer of each Employee
        /// </summary>
        /// <returns> Employee Comparer</returns>
        public static EmployeeComparer GetComparer()
        {
            return new EmployeeComparer();
        }

        /// <summary>
        /// Compare the right side of employee number
        /// </summary>
        /// <param name="rh"> Employee to Compare</param>
        /// <returns> a value to show less, greater or equal</returns>
        public int CompareTo(Employee rh)
        {
            return Number.CompareTo(rh.Number);
        }

        /// <summary>
        /// Comparing right hand side of whichcomparison
        /// </summary>
        /// <param name="rh">Comparing</param>
        /// <param name="whichcomparison"> Property to Compare</param>
        /// <returns> value to show greater, less or equal</returns>
        public int CompareTo(Employee rh, EmployeeComparer.ComparisonType whichcomparison)
        {
            switch (whichcomparison)
            {
                case EmployeeComparer.ComparisonType.Name:
                    return Name.CompareTo(rh.Name);
                case EmployeeComparer.ComparisonType.Number:
                    return Number.CompareTo(rh.Number);
                case EmployeeComparer.ComparisonType.Rate:
                    return Rate.CompareTo(rh.Rate) * -1;
                case EmployeeComparer.ComparisonType.Hours:
                    return Hours.CompareTo(rh.Hours) * -1;
                case EmployeeComparer.ComparisonType.Gross:
                    return Gross.CompareTo(rh.Gross) * -1;
            }
            return 0;
        }

        // Nested class to implement IComparer
        public class EmployeeComparer : IComparer<Employee>
        {
            public ComparisonType WhichComparison { get; set; }

            public enum  ComparisonType
            {
                Name, Number, Rate, Hours, Gross
            };

            /// <summary>
            /// Compares any two employee's left hand side and right hand side 
            /// </summary>
            /// <param name="lh"> Left hand side</param>
            /// <param name="rh">Right hand side</param>
            /// <returns>value to show greater, less or equal</returns>
            public int Compare(Employee lh, Employee rh)
            {
                return lh.CompareTo(rh, WhichComparison);
            }
        }
    }
}