/*
 * I Yagna Parekh , 000846481 certify that this material is my original work. 
 * No other person's work has been used without due acknowledgement.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_000846481
{
    class EmployeeDetails
    {
        private Employee[] employee;

        /// <summary>
        /// Employee's Constructor
        /// </summary>
        /// <param name="employee"> Employee[] employee</param>
        public EmployeeDetails(Employee[] employee)
        {
            this.employee = employee;
        }

        /// <summary>
        /// Asking the user to choose any option to sort 
        /// </summary>
        public void Selection()
        {
            SortingEmployee sort = new SortingEmployee(employee);
            Menu();
            while (true)
            {
                string option = Console.ReadLine();
                Console.Clear();
                if ((int.TryParse(option, out int choice) == false) || choice < 1) // has to be in range....
                {
                    Console.WriteLine("Invalid input! Please enetr valid option........");
                    
                }
                else if(choice == 6) // if 6 then exit the game
                {
                    break;
                }
                else if (choice == 1)
                {
                    sort.Sort_by_Name();
                }

                else if (choice == 2)
                {
                    sort.Sort_by_Number();
                }

                else if (choice == 3)
                {
                    sort.Sort_by_Rate();
                }

                else if (choice == 4)
                {
                    sort.Sort_by_Hours();
                }

                else if (choice == 5)
                {
                    sort.Sort_by_Gross();
                }
                Menu();
            }
        }

        /// <summary>
        /// Shows Menu to sort Employee's details
        /// </summary>
        public void Menu()
        {
            Console.WriteLine("\nMENU\n");
            Console.WriteLine("1 - Sort by Employee Name (Ascending)");
            Console.WriteLine("2 - Sort by Employee Number (Ascending)");
            Console.WriteLine("3 - Sort by Employee Pay Rate (Descending)");
            Console.WriteLine("4 - Sort by Employee Hours (Descending)");
            Console.WriteLine("5 - Sort by Employee Gross Pay (Descending)");
            Console.WriteLine("6 - Exit");
            Console.Write("Enter your choice: ");
        }
    }
}
