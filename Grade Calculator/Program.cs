using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int stutotel = 0;
            int graA = 0, graB = 0, graC = 0, graS = 0, graF = 0;
            Console.Write("===Student Grade Enrtry=== ");

            while (true)
            {

                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();
                getmarks:
                Console.Write("Enter Marks (out of 100): ");
                string input = Console.ReadLine();
                float marks;
                bool isValid = float.TryParse(input, out marks);
                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                    goto getmarks;
                }
                else if (marks < 0 || marks > 100)
                {
                    Console.WriteLine("Enter the value between 0 to 100");
                }
                else
                {
                    string grade;
                    if (marks > 75)
                    {
                        grade = "A";
                        graA++;
                    }
                    else if (marks > 65)
                    {
                        grade = "B";
                        graB++;
                    }
                    else if (marks > 55)
                    {
                        grade = "C";
                        graC++;
                    }
                    else if (marks > 45)
                    {
                        grade = "S";
                        graS++;
                    }
                    else
                    {
                        grade = "F";
                        graF++;
                    }

                    Console.WriteLine("Student: " + name + ", Grade: " + grade, " marks: " + marks);
                    stutotel++;
                }
                getinput:
                Console.WriteLine("Do you went to entry athour students? (Y/N)");
                string input1 = Console.ReadLine().ToUpper();
                if (input1 == "Y" || input1 == "N")
                {
                    if (input1 != "Y")
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input");

                    goto getinput;
                }
                    
            }
            Console.WriteLine("===SAMMARY REPORT==== ");
            Console.WriteLine("TOTAL Student:" + stutotel);
            Console.WriteLine("GRADE_A:" + graA);
            Console.WriteLine("GRADE_B:" + graB);
            Console.WriteLine("GRADE_C:" + graC);
            Console.WriteLine("GRADE_S:" + graS);
            Console.WriteLine("GRADE_F:" + graF);
            Console.WriteLine("ANY KEY PRESS EXIT...");
            Console.ReadKey();
            Console.ReadLine();

        }
    }
}