using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.Week1
{
    internal class NumberGuess
    {
        public void Run() 
        {
            Random random = new Random();

            bool play = true;

            int min = 1;
            int max = 100;
            int guess;
            int number;
            int attempts;
            string response;


            while (play)
            {
                guess = 0;
                attempts = 0;
                number = random.Next(min, max + 1);


                while (guess != number)
                {
                    Console.Write("Guess a number between " + min + " - " + max + ": ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low");
                    }
                    attempts++;
                }

                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Attempts: " + attempts);

                Console.Write("Do you want to guess again (y/n): ");
                response = Console.ReadLine();

                if (response == "y")
                {
                    play = true;
                }
                else if (response == "n")
                {
                    play = false;
                }


            }

            Console.WriteLine("Thanks for playing.");

            Console.ReadKey();
        }
    }
}
