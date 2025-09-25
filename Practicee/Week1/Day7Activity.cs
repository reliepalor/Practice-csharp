using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.Week1
{
    internal class Day7Activity
    {
        public void Run()
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();
        }
    }   

    abstract class Animal
    {   
        public virtual void Speak()
        {
            Console.WriteLine();
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("I am a dog");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Im a cat");
        }
    }
}
