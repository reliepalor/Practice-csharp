using Practicee.OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.GENERICS
{
    internal class Dictionary_
    {
        public void Run() 
        {
            Dictionary<string, List<Food>> orders = new Dictionary<string, List<Food>>();

            orders["Alice"] = new List<Food> { new Pizza("Hawaiian", 220, "Medium") };
            orders["Bob"] = new List<Food> { new Burger("Double Cheeseburger", 300) };

            Console.WriteLine($"Alice ordered: {orders["Alice"][0].Name}");

        }
    }
}
