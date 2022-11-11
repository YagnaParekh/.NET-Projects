/*
 * I Yagna Parekh , 000846481 certify that this material is my original work. 
 * No other person's work has been used without due acknowledgement.
 */


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_000846481
{
    class Program
    {
        /// <summary>
        /// Main program begins from here 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Employee[] employees = AccessEmployee();

            if(employees != null)
            {
                EmployeeDetails emp = new EmployeeDetails(employees);
                emp.Selection();
            }
        }

        /// <summary>
        /// Access data from employees file
        /// </summary>
        /// <returns></returns>
        /// 
        private static Employee[] AccessEmployee()
        {
            Employee[] emp = new Employee[100];
            int count = 0;
            int number = 1;

            // this will read the file 
            string filepath = "employees.txt";

            // try if something exception happens or not
            try
            {
              if (File.Exists("../../employees.txt"))
              filepath = "../../employees.txt";

              FileStream file = new FileStream(filepath, FileMode.Open);
              StreamReader stream = new StreamReader(file);

             // this will go to another line and reads the data continuosly after every next line
              while (!stream.EndOfStream && number < emp.Length)
              {
                 string input = stream.ReadLine();

                 if (input == "")
                 {
                    Console.WriteLine("LINE IS EMPTY AT " + number);
                    number++;
                    continue;
                 }

                 string[] vs = input.Split(',');

                // this will check if there is 4 columns or more than that
                 if (vs.Length != 4)
                 {
                    Console.WriteLine("This line does not contain the column 4 at " + number);
                    number++;
                    continue;
                 }

                 string name = vs[0];
                 if (int.TryParse(vs[1], out int num) == false)
                 {
                   Console.WriteLine("Error while getting employee's number: " + name);
                   num = 0;
                 }

                 if (double.TryParse(vs[2], out double rate) == false)
                 {      
                  Console.WriteLine("Error while getting employee's rate: " + name);
                  rate = 0;
                 }

                 if (double.TryParse(vs[3], out double hours) == false)
                 {
                   Console.WriteLine("Error while getting employee's hours: " + name);
                   hours = 0;
                 }

                 emp[count] = new Employee(name, num, (decimal)rate, hours);
                 count++;
                 number++;
              }
              file.Close();
              stream.Close();
             }

             catch (Exception ae) // will show an exception if it gets failed to load 
            {
              Console.WriteLine($"Faile to load Employees file because of : {ae.Message}");
            }

            // this is for given details in employees file
            
            Employee[] office_emp = new Employee[count];

            for(int i = 0; i < office_emp.Length; i++)
                office_emp[i] = emp[i];

            return office_emp;
        }
    }
}