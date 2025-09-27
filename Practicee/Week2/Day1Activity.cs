using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.Week2
{
    internal class Day1Activity
    {
        public void Run()
        {
            Console.WriteLine("Week 2 C#");

            List<string> languages = new List<string>();

            Console.WriteLine("What are your currently tech stack?");
            Console.WriteLine("Type 'done' when you're finished. \n");

            string response = "";

            while (true)
            {
                Console.Write("List: ");
                response = Console.ReadLine();

                if (response.ToLower() == "done")
                {
                    break;
                }

                if (!string.IsNullOrWhiteSpace(response))
                {
                    languages.Add(response);
                }
            }

            Console.WriteLine("These are your Programming language you list");

            int count = 1;
            foreach (string language in languages)
            {
                Console.WriteLine($"{count}. {language}");
            }
        }   
    }
}
