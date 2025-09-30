using Practicee.GENERICS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.GENERICS
{
    internal class LISTS
    {
        public void Run()
        {
            List<string> names = new List<string>();

            while (true)
            {
                Console.Write("Names: ");
                string inputNames = Console.ReadLine();

                if (inputNames.ToLower() == "done")
                {
                    break;
                }
                if(!string.IsNullOrWhiteSpace(inputNames)) 
                { 
                    names.Add(inputNames);
                }
            }
           
            foreach (var name in names)
            {
                Console.Write(name + ", ");
            }
        }


    }
}
