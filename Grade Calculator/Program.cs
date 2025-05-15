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
             Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Marks (out of 100): ");
            string input = Console.ReadLine();
            int marks;
            bool isValid = int.TryParse(input, out marks);
            if (!isValid)
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
            else if (marks <0 || marks> 100)
            {
                Console.WriteLine("Enter the value between 0 to 100");
            }
            else {
                string grade;
                if (marks > 75)
                    grade = "A";
                else if (marks > 65)
                    grade = "B";
                else if (marks > 55)
                    grade = "C";
                else if (marks > 45)
                    grade = "S";
                else
                   grade = "F";

                Console.WriteLine("Student: " + name + ", Grade: " + grade);
            }
            
            Console.ReadLine();
        }
    }
}
