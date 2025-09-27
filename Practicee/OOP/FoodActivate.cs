using Practicee.OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.OOP
{
    internal class FoodActivate
    {
        public void Run()
        {
            List<Food> menu = new List<Food>()
            {
                new Pizza("Pepperoni Pizza", 12.99, "Large"),
                new Salad("Caesar Salad", 6.50),
                new Burger("Cheeseburger", 8.75)
            };

            Console.WriteLine("== Welcpme to Food Ordering System ===\n");
            Console.WriteLine("Menu: ");
            int index = 1;

            foreach (var item in menu)
            {
                Console.WriteLine($"{index}. {item.Name} - {item.Price}");
                index++;
            }
            Console.Write("\nEnter the number of the food you want to order: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice > 0 && choice <= menu.Count)
            {
                Food selectedFood = menu[choice - 1];
                selectedFood.Order();
                selectedFood.Serve();
            }
            else 
            {
                Console.WriteLine("Invalid choice.");
            }
            Console.WriteLine("\nThank you for ordering!");
        }
    }
}
