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
using System.IO;

namespace Lab4A
{
    class Program
    {
        /// <summary>
        /// Main method of Program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Employee> employees = Read();

            if(employees != null)
            {
                ViewEmployee viewEmployee = new ViewEmployee(employees);
                viewEmployee.UserSelection();
            }
        }


        /// <summary>
        /// Reading the employee.txt file 
        /// </summary>
        /// <returns> Array from the file</returns>
        private static List<Employee> Read()
        {
            List<Employee> employees = new List<Employee>();
            int line = 1;

            // File path
            string file = "employees.txt";

            try
            {
                if (File.Exists("../../employees.txt"))
                    file = "../../employees.txt";

                FileStream fs = new FileStream(file, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
               
                while(!sr.EndOfStream)
                {
                    // Next line
                    string input = sr.ReadLine();

                    // If line is empty or not
                    if(input != "")
                    {
                        string[] values = input.Split(',');

                        if(values.Length != 4)
                        {
                            Console.WriteLine("In file: 'employees.txt', Line does not contain enough columns at" + line);
                            line++;
                            continue;
                        }

                        string name = values[0];

                        if(int.TryParse(values[1], out int num) == false)
                        {
                            Console.WriteLine("Failed to fetch employee's number for" + name);
                            num = 0;
                        }
                        if (int.TryParse(values[2], out int rate) == false)
                        {
                            Console.WriteLine("Failed to fetch employee's rate for" + name);
                            rate = 0;
                        }
                        if (int.TryParse(values[3], out int hours) == false)
                        {
                            Console.WriteLine("Failed to fetch employee's working hours for" + name);
                            hours = 0;
                        }

                        employees.Add(new Employee(name, num, rate, hours));
                    }
                }
                fs.Close();
                sr.Close();
            }
            catch(Exception ae)
            {
                Console.WriteLine($"Exception while loading the file :{ ae.Message}");
            }
            return employees;
        }
    }
}
