using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.Week1
{
    internal class Day4
    {
        public void Run()
        {
            double grade1, grade2, grade3, grade4, grade5, grade6;
            bool isRunning = true;
            Console.WriteLine("CALCULATE YOUR TOTAL GRADES \n");

            while (isRunning)
            {
                try
                {
                    Console.Write("Grade 1: ");
                    grade1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Grade 2: ");
                    grade2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Grade 3: ");
                    grade3 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Grade 4: ");
                    grade4 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Grade 5: ");
                    grade5 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Grade 6: ");
                    grade6 = Convert.ToDouble(Console.ReadLine());

                    double total = SumGrades(grade1, grade2, grade3, grade4, grade5, grade6);

                    double average = AverageGrades(total, 6);

                    Console.WriteLine("Total Grades: " + total);
                    Console.WriteLine("Average Grades: " + average);

                    Console.Write("Do you want to calculate again (y/n)?");
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "yes" || answer == "y")
                    {
                        isRunning = true;
                    }
                    else
                    {
                        isRunning = false;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("\nPlease enter letter only. \n");
                }
           


            }
            
        }

        static double SumGrades(params double[] grades)
        {
            double total = 0;

            foreach (double grade in grades)
            {
                total += grade;
            }

            return total;
        }

        static double AverageGrades(double total, int count) 
        {
            return total / count;
        }
     
    }
}
