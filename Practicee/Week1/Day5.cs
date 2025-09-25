using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.Week1
{
    internal class Day5
    {
        public void Run()
        {
            Students student = new Students();

            Console.WriteLine("1. Add Student \n" +
                  "2. Call Student");

            Console.WriteLine("What service do you want?");
            string response = Console.ReadLine();

            switch (response)
            { 
                case "1":
                    student.AddStudent();
                    break;
                case "2":
                    student.CallStudent();
                    break;
                default:
                    Console.WriteLine("Please choose Again");
                    break;
            }
        }
    }

    class Students
    {
        string name;
        string course;
        string studentID;
        string number;

        public void AddStudent()
        {
            Console.Write("What is your name: ");
            name = Console.ReadLine();
            Console.Write("What course are you taking: ");
            course = Console.ReadLine();
            Console.Write("What is your student ID: ");
            studentID = Console.ReadLine();

            Console.WriteLine($"Student Name: {name}\nCourse: {course}\nStudent ID: {studentID}");
        }

        public void CallStudent()
        {
            Console.Write("Enter number:");
            number = Console.ReadLine();

            Console.Write("What is your name: ");
            name = Console.ReadLine();

            Console.WriteLine($"Calling {name} \n Number: {number}");
        }
    }
}
