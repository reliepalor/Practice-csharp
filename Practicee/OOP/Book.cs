using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.OOP
{
    internal class Book
    {
        public string title;
        public string author;
        public int yearPublished;
        public bool isAvailable;

        public Book(string title, string author, int yearPublished)
        {
            this.title = title;
            this.author = author;
            this.yearPublished = yearPublished;
            this.isAvailable = true;
        }

        public string Title { get => title; }
        public string Author { get => author; }
        public int YearPublished { get => yearPublished; }
        public bool IsAvailable { get => isAvailable; }

        public virtual void Borrow()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine($"\n{title} has been borrowed.");
            }
            else 
            {
                Console.WriteLine($"\n{title} is already borrowed.");
            }
        }

        public void Return()
        {
            isAvailable = true;
            Console.WriteLine($"{title} has been returned.");
        }
    }

    class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(IEnumerable<Book> booksToAdd)
        {
            books.AddRange(booksToAdd);
        }

        public void ShowBooks()
        {
            for (int i = 0; i < books.Count; i++)
            {
                var book = books[i]; // Corrected variable name
                string status = book.IsAvailable ? "Available" : "Borrowed";
                Console.WriteLine($"Book{i + 1} -- {book.title} by {book.author} {book.YearPublished} -- [{status}]");
            }
        }
        public Book GetBookByTitle(string title)
        {
            return books.FirstOrDefault(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        public Book GetBookByNumber(string bookNumber)
        {
            if (bookNumber.ToLower().StartsWith("book"))
            {
                string numberPart = bookNumber.Substring(4); // still works
                if (int.TryParse(numberPart, out int index))
                {
                    if (index > 0 && index <= books.Count)
                    {
                        return books[index - 1];
                    }
                }
            }
            return null;
        }

    }

    class EBook : Book 
    {
        public double FileSizeMB { get; set; }

        public EBook(string title, string author, int year, double fileSize)
            : base(title, author, year)
        {
            FileSizeMB = fileSize;
        }

        public override void Borrow()
        {
            Console.WriteLine($"{Title} (Ebook) downloaded. Size: {FileSizeMB}MB");
        }
    }
    class PrintedBook : Book 
    {
        public int Pages { get; set; }

        public PrintedBook(string title, string author, int year, int pages)
            : base(title, author, year)
        {
            Pages = pages;
        }

        public override void Borrow()
        {
            base.Borrow();
            Console.WriteLine($"You took a printed copy of {Title}, {Pages} pages.");

        }
    }
}
