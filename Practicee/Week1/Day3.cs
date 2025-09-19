using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.Week1
{
    internal class Day3
    {
        public void Run()
        {
            String[] techs = { "React JS","Tailwind CSS","Laravel", "ASP .NET", "C#"};

            /*
            for (int i = 1; i < techs.Length; i++)
            {
                Console.WriteLine( "\t " +i +". "+ techs[i]);
            }
            */

            foreach (string tech in techs)
            {
                Console.WriteLine(tech);
            }
        }


    }
}
