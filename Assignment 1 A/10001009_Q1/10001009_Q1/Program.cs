using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001009_Q1
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book();

            Console.WriteLine("*** ENTER NEW BOOK DETAILS BELOW ***");
            Console.Write("\nEnter book title: ");
            book1.SetTitle(Console.ReadLine());
            Console.Write("Enter author: ");
            book1.SetAuthor(Console.ReadLine());
            Console.Write("Enter publisher: ");
            book1.SetPublisher(Console.ReadLine());

            Console.WriteLine("\n******************************************");
            Console.WriteLine("The following new book has been published:");
            Console.WriteLine("Book Title: " + book1.GetTitle());
            Console.WriteLine("Author: " + book1.GetAuthor());
            Console.WriteLine("Publisher: " + book1.GetPublisher());

            Console.ReadLine();

        }
    }

    class Book
    {
        private string title;
        private string author;
        private string publisher;

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string tle)
        {
            title = tle;
       
        }

        public string GetAuthor()
        {
            return author;
        }

        public void SetAuthor(string au)
        {
            author = au;
           
        }

        public string GetPublisher()
        {
            return publisher;
        }

        public void SetPublisher(string pub)
        {
            publisher = pub;
        }

    }
}
