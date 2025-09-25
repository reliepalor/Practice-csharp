using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Practicee.Week1
{

    class Student
    {
        public string name;

        public Student(string name)
        {
            this.name = name;
            Console.WriteLine($"Student name is {name}");
        }
    }
    internal class Day6
    {
        public void Run()
        {

            Student student1 = new Student("John");
            Student student2 = new Student("Trisha");
            Student student3 = new Student("Vue");

            Console.WriteLine("--------------------");
            
            SportsCar myCar = new SportsCar();
            myCar.TopSpeed();
            SUV suv = new SUV();
            suv.TopSpeed();
          //  myCar.speed = 200;
            //Console.WriteLine($"My {myCar.brand} {myCar.modelName} has a top speed of {myCar.speed}");
        }
    }

    class Vehicle
    {
        public string brand = "Ford";
        public int speed = 0;

        public void go(int speed)
        {
            this.speed = speed;
            Console.WriteLine($" top speed is {speed}");
        }

        public virtual void TopSpeed()
        {
            Console.WriteLine("Default top speed is 100 kmph");
        }
    }


    class SportsCar : Vehicle
    {
        public string modelName = "Mustang";

        public override void TopSpeed()
        {
            Console.WriteLine("My Top Speed is 350+ kmph");
        }
    }

    class SUV : Vehicle 
    {
        public string modelName = "Everest";

        public override void TopSpeed()
        {
            Console.WriteLine("My Top Speed is 200+ kmph");
        }
    }



   
}
