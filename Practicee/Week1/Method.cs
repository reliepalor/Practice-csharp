using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.Week1
{
    internal class Method
    {
        public void Run()
        {

            double a;
            double b;
            double sum;

            Console.Write("enter num 1: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter num 2: ");
            b = Convert.ToDouble(Console.ReadLine());

            sum = Multiply(a, b);

            Console.WriteLine($"{a} + {b} = {sum}");

        }
        static double Multiply(double a, double b)
        {
            double sum = a * b;
            return sum;
        }
        void GreetUser(String name)
        {
            Console.WriteLine("hello " + name);
        }
    }
}
