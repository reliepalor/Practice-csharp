using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.Week1
{
    internal class Lists
    {
        public void Run()
        {
            List<string> food = new List<string>();
            List<double> priceList = new List<double>();

            food.Add("Shanghai");
            food.Add("Chicken Wings");
            food.Add("Ice Cream");

            priceList.Add(12.5);
            priceList.Add(33.8);
            priceList.Add(20.5);

            foreach (string item in food)
            {
                Console.WriteLine(item);
            }

            foreach (int price in priceList)
            {
                Console.WriteLine(price);
            }

            //INSERT
            Console.Write("What food you want to Add: ");
            string addedFood = Console.ReadLine();
            food.Insert(0, addedFood);

            //REMOVE
            Console.Write("What food you want to remove: ");
            string deletedFood = Console.ReadLine();
            food.Remove(deletedFood);

            foreach (string item in food)
            {
                Console.WriteLine(item);
            }

          /*
            Console.WriteLine(food.count);
            Console.WriteLine(0, "sushi");
            Console.WriteLine(food.IndexOf("Ice Cream"));
            Console.WriteLine(food.LastIndexOf("Ice Cream"));
            Console.WriteLine(food.Contains("Ice Cream"));
            food.Sort();
            food.Reverse();
            food.Clear();
          */

        }
    }
}
