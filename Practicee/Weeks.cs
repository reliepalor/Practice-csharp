using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Weeks
    {
        public void Run()
        {
            Console.WriteLine("Day of the week");

            Console.Write("Enter a number 1 - 7: ");
            string day = Console.ReadLine();

            switch (day)
            { 
                case "1":
                    Console.WriteLine("Sunday");
                    break;
                case "2":
                    Console.WriteLine("Monday");
                    break;
                case "3":
                    Console.WriteLine("Teusday");
                    break;
                case "4":
                    Console.WriteLine("Wednesday");
                    break;
                case "5":
                    Console.WriteLine("Thursday");
                    break;
                case "6":
                    Console.WriteLine("Friday");
                    break;
                case "7":
                    Console.WriteLine("Saturday");
                    break;
            }

        }
    }
}
