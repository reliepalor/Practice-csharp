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
            IterateDictionary();
        }

        private static void IterateDictionary()
        {
            Dictionary<string, Food> foods = makeFood();

            foreach (KeyValuePair<string, Food> fcode in foods)
            {
                Food FoodCode = fcode.Value;

                Console.WriteLine("Food Code: " + fcode.Key);
                Console.WriteLine($"Food: {FoodCode.Category} {FoodCode.Name} {FoodCode.Price}\n");
            }
        }

        public class Food
        { 
            public required string Category { get; set; }
            public required string Name { get; set; }
            public required double Price { get; set; }

        }

        private static Dictionary<string, Food> makeFood()
        {
            Dictionary<string, Food> foods = new Dictionary<string, Food>();
            foods.Add("A1", new Food() { Category = "Appetizer", Name = "Spring Roll", Price = 5.00 });
            foods.Add("A2", new Food() { Category = "Appetizer", Name = "Garlic Bread", Price = 4.00 });
            foods.Add("M1", new Food() { Category = "Main Course", Name = "Grilled Chicken", Price = 15.00 });
            foods.Add("M2", new Food() { Category = "Main Course", Name = "Pasta", Price = 12.00 });
            foods.Add("D1", new Food() { Category = "Dessert", Name = "Cheesecake", Price = 6.00 });
            foods.Add("D2", new Food() { Category = "Dessert", Name = "Ice Cream", Price = 4.00 });
            return foods;
        }
    }
}
