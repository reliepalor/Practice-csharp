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
            Menu menu = new Menu();
            menu.AddFood(new List<Food>
    {
        new Pizza("Pepperoni", 250, "Large"),
        new Salad("Caesar Salad", 150),
        new Burger("Cheeseburger", 200)
    });

            Console.WriteLine("== Welcome to Food Ordering System ===\n");
            Console.WriteLine("Menu: ");
            menu.ShowFoods();

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
