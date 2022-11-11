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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4A
{
    class ViewEmployee
    {
        public List<Employee> Employees { get; set; }
        private Employee.EmployeeComparer compare_employee = Employee.GetComparer();

        /// <summary>
        /// Main Constructor for Employee Details
        /// </summary>
        /// <param name="employees"> List of Employees</param>
        public ViewEmployee(List<Employee> employees)
        {
            Employees = employees;
        }

        /// <summary>
        /// Process of what user selects and what should be displayed
        /// </summary>
        /// <returns>runs if all conditions are true</returns>
        public bool UserSelection()
        {
            Console.Title = "Employee Details";
            Console.WriteLine("EMPLOYEE DETAILS");
            Console.WriteLine("Created by Yagna Parekh - 000846481");
            Console.WriteLine("\nSelect any employee and manipulate his pay and hours");

            DisplayMenu();

            while(true)
            {
                string select = Console.ReadLine();
                Console.Clear();
                if((int.TryParse(select, out int userSelects) == false) || userSelects < 1 || userSelects > 6)
                {
                    Console.WriteLine("\nInvalid input entered. Please enter a valid number....");
                    continue;
                }

                if (userSelects == 1)
                    compare_employee.WhichComparison = Employee.EmployeeComparer.ComparisonType.Name;
                else if (userSelects == 2)
                    compare_employee.WhichComparison = Employee.EmployeeComparer.ComparisonType.Number;
                else if (userSelects == 3)
                    compare_employee.WhichComparison = Employee.EmployeeComparer.ComparisonType.Rate;
                else if (userSelects == 4)
                    compare_employee.WhichComparison = Employee.EmployeeComparer.ComparisonType.Hours;
                else if (userSelects == 5)
                    compare_employee.WhichComparison = Employee.EmployeeComparer.ComparisonType.Gross;
                else
                    break;// if user selects 6, program must stop

                DisplayHeader();

                Employees.Sort(compare_employee);
                foreach (Employee emp in Employees)
                    Console.WriteLine(emp);

                Console.WriteLine("");
                DisplayMenu();
            }
            return true;
        }

        /// <summary>
        /// Displaying menu for the user
        /// </summary>
        public void DisplayMenu()
        {
            Console.WriteLine("1. Sort Employee Name");
            Console.WriteLine("2. Sort Employee Number");
            Console.WriteLine("3. Sort Employee Pay Rate");
            Console.WriteLine("4. Sort Employee Hours");
            Console.WriteLine("5. Sort Employee Gross Pay");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Enter your choice");
        }
        /// <summary>
        /// Showing the header
        /// </summary>
        public void DisplayHeader()
        {
            Console.WriteLine($"{"Employee", -20}  {"Number", 6}  {"Rate", 6}   {"Hours", 5}    {"Gross Pay", 9}   ");
            Console.WriteLine("=========================  =======  ===== =====   ========");
        }
    }
}
