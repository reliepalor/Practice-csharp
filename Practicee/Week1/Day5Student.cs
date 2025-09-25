using System;

namespace Practicee.Week1
{
    internal class Day5Student
    {
        string id;
        string name;
        string course;
        int year;

        public Day5Student(string id, string name, string course, int year)
        {
            this.id = id;
            this.name = name;
            this.course = course;
            this.year = year;
        }

        public void Attendance()
        {
            Console.WriteLine($"{name}'s Attendance is recorded.");
        }

        // Example test method
        public void Run()
        {
            Motorcycle moto1 = new Motorcycle();
            Bike bike1 = new Bike();

            moto1.Go();
            bike1.Go();
        }
    }

    class Car
    {
        string Model;
        public static int CarsNumber;
        public int speed = 0;

        public Car(string model)
        {
            this.Model = model;
            CarsNumber++;
        }

        public void Go()
        {
            Console.WriteLine($"{Model} is fast and iconic");
        }
    }

    class Motorcycle : Car
    {
        public int seat = 2;

        public Motorcycle() : base("Motorcycle") { }
    }

    class Bike : Car
    {
        public int seat = 1;

        public Bike() : base("Bike") { }
    }

    class Books
    {
        string title;
        string author;
        string section;
        int yearPublished;

        public Books(string title, string author, string section, int yearPublished)
        {
            this.title = title;
            this.author = author;
            this.section = section;
            this.yearPublished = yearPublished;
        }

        public Books(string title, string author, string section)
        {
            this.title = title;
            this.author = author;
            this.section = section;
        }
    }
}
