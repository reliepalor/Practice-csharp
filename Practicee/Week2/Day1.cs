using Practicee.Week1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.Week2
{
    internal class Day1
    {
        public void Run()
        {
            /*
            List<Player> players = new List<Player>();

            Player player1 = new Player("Naruto");
            Player player2 = new Player("Sasuke");
            Player player3 = new Player("Luffy");

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }


            List<Todo> todos = new List<Todo>();

            Console.WriteLine("\nTodo List\n");

            string response = "";

            while (true)
            {
                Console.Write("Todo: ");
                response = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(response))
                {
                    todos.Add(new Todo(response));
                }
                foreach (Todo todo in todos)
                {
                    Console.WriteLine($"- {todo.Task}\n");
                }

                Console.Write("Do you want to add again? y/n: ");
                string answer = Console.ReadLine().ToLower();
                if (answer == "n")
                {
                    break;
                }

            }
            */
            Student student = new Student(95);
            student.Grade = 520;

            Console.WriteLine(student.Grade);

        }

        class Player
        {
            public string username;

            public Player(string username)
            {
                this.username = username;
            }

            public override string ToString()
            {
                return $"Player: {username}";
            }
        }

        class Todo
        {
            public string Task { get;  }

            public Todo(string Task)
            {
                this.Task = Task;
            }

            public override string ToString()
            {
                return $"- {Task}\n";
            }
        }
    }

    class Student
    {
        public int grade;

        public Student(int grade) 
        {
            Grade = grade;
        }

        public int Grade
        {
            get 
            {
                return grade;
            }
            set
            {
                if (value > 90)
                {
                    grade = 500;
                }
                else
                {
                    grade = value; 
                }

            }
        }
    }
}
