using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.Week1
{
    internal class Day3Activity
    {
        public void Run()
        {
          

            Console.WriteLine("Welcome to CoffeeTime");

            ShowMenu();

            Console.Write("\n Enter your choice (1-3): ");
            string choice = Console.ReadLine();

            string item = "";
            double price = 0;

            switch (choice)
            {
                case "1":
                    item = "Latte";
                    price = 3.05;
                    break;
                case "2":
                    item = "Espresso";
                    price = 2.75;
                    break;
                case "3":
                    item = "Cappuciono";
                    price = 3.65;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return; 
            }
            TakeOrder(choice);
            PrinitReceipt(item, price);
        }

        static void ShowMenu()
        {
            Console.WriteLine("\nMenu: " +
                "\n 1. Latte - $3.05" +
                "\n 2. Espresso - $2.05" +
                "\n 3. Cappuccino - $4.05");
        }

        static void TakeOrder(String choice)
        {
            Console.WriteLine($"\n You have selected option {choice}");

        }

        static void PrinitReceipt(string item, double price)
        {
            Console.WriteLine("Final order:" +
                $"{item} : ${price}");

        }
    }
}
