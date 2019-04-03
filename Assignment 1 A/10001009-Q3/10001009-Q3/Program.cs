using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001009_Q3
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book();

            Console.WriteLine("*** ENTER NEW BOOK DETAILS BELOW ***");
            Console.Write("\nEnter book title: ");
            book1.Title = Console.ReadLine();
            Console.Write("Enter author: ");
            book1.Author = Console.ReadLine();
            Console.Write("Enter publisher: ");
            book1.Publisher = Console.ReadLine();

            Console.WriteLine("\n******************************************");
            Console.WriteLine("The following new book has been published:");
            Console.WriteLine("Book Title: " + book1.Title);
            Console.WriteLine("Author: " + book1.Author);
            Console.WriteLine("Publisher: " + book1.Publisher);

            Console.ReadLine();
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }


        public Book()
        {

        }

        public Book( string title, string author, string publisher)
        {
            Title = title;
            Author = author;
            Publisher = publisher;

            
        }

    }
}
