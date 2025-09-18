using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.Week1
{
    internal class Activity
    {
        public void Run()
        {
            Console.Write("Username: ");
            string getUsername = Console.ReadLine();

            Console.Write("Password: ");
            string getPassword = Console.ReadLine();

            if (getPassword == "admin" && getUsername == "admin@gmail.com")
            {
                Console.WriteLine("Login successful!");
            } else if (getUsername == "Guest" && getPassword == "Guest")
            {
                Console.WriteLine("Welcome, Guest!");
            }
            else
            {
                Console.WriteLine("Invalid credentials!");
            }


            Console.WriteLine();
        }
    }
}
