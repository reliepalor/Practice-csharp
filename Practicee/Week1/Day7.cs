using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.Week1
{
    internal class Day7
    {
        public void Run()
        {
            StudentList student1 = new StudentList("Relie", "BSIT", "3", 4);
            StudentList student = new StudentList("Default Name", "Default Course", "Default Section", 1);
            Console.WriteLine(student);

            Console.WriteLine("----------Polymorphism---------");

            Jets jet1 = new Jets();
            Boeing boeing1 = new Boeing();
            Airbus airbus1 = new Airbus();

            Planes[] planes = { jet1, boeing1, airbus1 };

            foreach (Planes plane in planes)
            {
                plane.Go();
            }
        }
    }
    class Planes
    {
        public virtual void Go()
        {
        }
    }
    class Jets : Planes
    {
        public override void Go()
        {
            Console.WriteLine("The Jets are flying");
        }

    }
    class Boeing : Planes
    {
        public override void Go()
        {
            Console.WriteLine("The Boeing are flying");
        }
    }
    class Airbus : Planes
    {
        public override void Go()
        {
            Console.WriteLine("The Airbus are flying");
        }
    }

    class StudentList
    {
        public string name;
        public string course;
        public string section;
        int year;

        public StudentList(string name, string course, string section, int year)
        {
            this.name = name;
            this.course = course;
            this.section = section;
            this.year = year;
        }

        public override string ToString()
        {
            return "Name: " + name + "\nCourse: " + course + "\nSection: " + section + "\nYear: " + year;
        }
    }
}

