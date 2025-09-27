using Practicee.OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.OOP
{
    internal class LibraryActivate
    {
        public void Run()
        {
            Library library = new Library();

            library.AddBook(new List<Book>
            {
                new PrintedBook("The Lord of the Rings", "J.R.R. Tolkien", 1937, 310),
                new EBook("Clean Code", "Robert C. Martin", 2008, 1.5),
                new PrintedBook("The Pragmatic Programmer", "Andrew Hunt", 1999, 352),
                new EBook("Refactoring", "Martin Fowler", 2018, 4.2),
                new PrintedBook("1984", "George Orwell", 1949, 328),
                new EBook("Design Patterns", "Erich Gamma", 1994, 2.8),
                new PrintedBook("Dune", "Frank Herbert", 1965, 412)
            });
            while (true)
            {
                library.ShowBooks();

                Console.Write("\nChoose Books: ");
                string choice = Console.ReadLine();

                Book selectedBookNumber = library.GetBookByNumber(choice);

                if (selectedBookNumber != null)
                {
                    selectedBookNumber.Borrow();
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }

                Console.WriteLine("");
                library.ShowBooks();

                Console.Write("\ndo you want to borrow again? y/n:");
                string respone = Console.ReadLine().ToLower();
                if (respone != "y")
                {
                    break;

                }
                
            }
        }
    }
}
