using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.Week1
{
    internal class Calculator
    {
        public void Run()
        {
            Console.WriteLine("CALCULATOR APP\n");

            bool isRunning = true;

            while (isRunning)
            {

                Console.Write("Enter first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Choose Operation: (* , + , - , /): ");
                char operation = Convert.ToChar(Console.ReadLine());

                Console.Write("Enter second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (operation)
                {
                    case '*':
                        result = num1 * num2;
                        Console.WriteLine("Result: " + result);
                        break;
                    case '+':
                        result = num1 + num2;
                        Console.WriteLine("Result: " + result);
                        break;
                    case '-':
                        result = num1 - num2;
                        Console.WriteLine("Result: " + result);
                        break;
                    case '/':
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                        break;
                }

                Console.Write("Do you want to use calculator again? (y/n): ");
                string response = Console.ReadLine().ToLower();

                if (response == "n")
                {
                    isRunning = false;
                    Console.WriteLine("Thank you for using the calculator. Goodbye!");
                }
                else if (response != "y")
                {
                    Console.WriteLine("Invalid. please enter (y/n) \n");
                }
            }


        }
    }
}
