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
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[100];

            String prompt_user = "";// ask user to enter his choice

            do
            {
                int shapenum = Shape.GetCount();// counts number of shapes will be adding 

                Console.Clear();
                Console.WriteLine("Yagna's Geometry Class");

                Console.WriteLine("A : Box          E : Circle    I : Cube");
                Console.WriteLine("B : Cylinder     F : Eclipse   J : Rectangle");
                Console.WriteLine("C : Sphere       G : Square");
                Console.WriteLine("D : Tetrahedron  H : Triangle\n");
                Console.WriteLine("0 :  Display all the shapes and stop the application.....\n");
                Console.WriteLine("{0} shapes have been added.\n", shapenum);
                Console.WriteLine("Enter your choice: ", shapenum);
                prompt_user = Console.ReadLine().ToUpper();
                Console.WriteLine();

                /*
                 * Condition to after user enters his choice which shape should be excecuted
                 */
                switch (prompt_user)
                {
                    case "A":
                        shapes[shapenum] = new Box();// if A then Box
                        break;
                    case "B":
                        shapes[shapenum] = new Cylinder();// if B then Cylinder
                        break;
                    case "C":
                        shapes[shapenum] = new Sphere();// if C then Sphere
                        break;
                    case "D":
                        shapes[shapenum] = new Tetrahedron();// if D then Tetrahedron
                        break;
                    case "E":
                        shapes[shapenum] = new Circle();// if E then Circle
                        break;
                    case "F":
                        shapes[shapenum] = new Eclipse();// if F then Eclipse
                        break;
                    case "G":
                        shapes[shapenum] = new Square();// if G then Sqaure
                        break;
                    case "H":
                        shapes[shapenum] = new Triangle();// if H then Traingle
                        break;
                    case "I":
                        shapes[shapenum] = new Cube();// if I then Cube
                        break;
                    case "J":
                        shapes[shapenum] = new Rectangle();// if J then Rectangle
                        break;
                    default:
                        Console.WriteLine("You must enter valid letter or a number 0-1. ");
                        break;
                }
            } while (prompt_user != "0" && Shape.GetCount() < 100);
            // if user enters 0 or total number of shapes are more than 100 applicaton will stop and show all shapes and their details
            {
                Console.Clear();
                Console.WriteLine("Displaying all Shapes.....");

                Console.WriteLine("{0} shapes have been added.\n", Shape.GetCount());

                Console.WriteLine("Shape           Area             Volume          Details");
                Console.WriteLine("-------------   --------------   --------------  ---------------------");


                // for loop to add shapes and show them
                for(int i = 0; i < Shape.GetCount(); i++)
                {
                    Console.WriteLine(shapes[i].ToString());
                }
                Console.ReadLine();
            }
        }
    }
}