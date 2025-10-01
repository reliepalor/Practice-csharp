using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.COLLECTIONS
{
    internal class Sample
    {
        public void Run()
        {
            Console.WriteLine("COLLECTIONS");

            /*
            List<string> names = new List<string>();
            string inputNames;
            Console.WriteLine("type 'done' if your done");
            while (true)
            {
                
                
                Console.Write("name: ");
                inputNames = Console.ReadLine();

                if (inputNames == "done") 
                {
                    break;
                }
                if (!string.IsNullOrWhiteSpace(inputNames))
                {
                    names.Add(inputNames);
                }
            }
            foreach (var name in names)
            {
                Console.Write(name + ", ");
            }
            Console.WriteLine("\ndo you want to remove names? y/n");
            string response = Console.ReadLine().ToLower();

            if (response == "y")
            {
                Console.Write("name to remove: ");
                string nameToRemove = Console.ReadLine();
                names.Remove(nameToRemove);
            }
            else
            {
                Console.WriteLine("ok");
            }

            foreach (var name in names)
            {
                Console.Write("\n" + name + ", ");
            }
            */

            IterateList();
        }

        public static void IterateList()
        {
            var thePets = new List<Pets>
            {
                new Pets() { Name="Vuevue", Type="Cat", Age=1},
                new Pets() { Name="UngAng", Type="Cat", Age=5}
            };
            foreach (Pets pet in thePets)
            {
                Console.WriteLine($" Im a {pet.Type}, my name is {pet.Name} {pet.Age} yrs old");
            }

            
        }
        public class Pets
        { 
            public string Name { get; set; }
            public string Type { get; set; }
            public int Age { get; set; }
        }
    }
}
