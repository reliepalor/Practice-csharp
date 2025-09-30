using Practicee.GENERICS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.GENERICS
{
    internal class Generic
    {
        public void Run()
        {
            int[] Years = [1, 2, 3, 4];
            string[] Colleges = ["CICS", "CTED", "CCJE", "CHM"];
            string[] Students = ["Vue vue", "Ung Ang", "Jaya"];

            DisplayElements(Years);
            DisplayElements(Colleges);
            DisplayElements(Students);
        }

        public static void DisplayElements<T>(T[] years)
        {
            foreach (T year in years)
            {
                Console.Write(year + ", ");
            }
            Console.WriteLine(" ");
        }
    }
}
