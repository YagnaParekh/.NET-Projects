
/*
 * I Yagna Parekh , 000846481 certify that this material is my original work. 
 * No other person's work has been used without due acknowledgement.
 * 
 * Sorting Idea fro Lecture Video In Week 3 Module
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace Lab_1_000846481
{
    class SortingEmployee
    {
        Employee[] employee;
        /// <summary>
        /// Sorting Constructor
        /// </summary>
        /// <param name="employee"></param>
        public SortingEmployee(Employee[] employee)
        {
            this.employee = employee;
        }
        
        /// <summary>
        /// Sortig the rate in descending 
        /// </summary>
        public void Sort_by_Rate()
        {
            var sortedRate =
                from e in employee
                orderby e.GetRate() descending
                select e;

            ViewHeader();

            foreach (var emp in sortedRate)
                Console.WriteLine(emp);
        }

        /// <summary>
        /// Sorting employee's name
        /// </summary>
        public void Sort_by_Name()
        {
            var sortedName =
                from e in employee
                orderby e.GetName()
                select e;

            ViewHeader();

            foreach (var emp in sortedName)
                Console.WriteLine(emp);
        }

        /// <summary>
        /// Sorting employee's number in ascending
        /// </summary>
        public void Sort_by_Number()
        {
            var sortedNumber =
                from e in employee
                orderby e.GetNum() 
                select e;

            ViewHeader();

            foreach (var emp in sortedNumber)
                Console.WriteLine(emp);
        }

        /// <summary>
        /// Sorting employee's working hours in descending
        /// </summary>
        public void Sort_by_Hours()
        {
            var sortedHours =
                from e in employee
                orderby e.GetHours() descending
                select e;

            ViewHeader();

            foreach (var emp in sortedHours)
                Console.WriteLine(emp);
        }

        /// <summary>
        /// Sorting Gross rate in descending
        /// </summary>
        public void Sort_by_Gross()
        {
            var sortedGross =
                from e in employee
                orderby e.getGross() descending
                select e;

            ViewHeader();

            foreach (var emp in sortedGross)
                Console.WriteLine(emp);
        }

        /// <summary>
        /// Viewing Header
        /// </summary>
        public void ViewHeader()
        {
            Console.WriteLine("Employee,\tNumber, \tRate, \tHours, \tGross");
            Console.WriteLine("---------       --------        ------- -------- ------");
        }
    }
}
