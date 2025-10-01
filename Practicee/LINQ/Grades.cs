using Practicee.LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.LINQ
{
    internal class Grades
    {
        public void Run()
        {
            List<string> Cats = new List<string>();
            Cats.Add("Misty");
            Cats.Add("Vuevue");
            Cats.Add("Ungang");
            Console.WriteLine("Available Petss");
            int count = 1;
            foreach (var cat in Cats)
            {
                
                Console.WriteLine($"{count}. {cat} ");
                count++;
            }

            Console.WriteLine("\n");

            Console.Write("What pet do you like: ");
            string getPet = Console.ReadLine();

            Console.WriteLine("\n");
            IEnumerable<string> CatsQuery =
                from cat in Cats
                where cat == getPet
                select cat;

            foreach (var i in CatsQuery)
            {
                Console.Write($"Yey i got {i}");
            }

            
        }
    }
}
