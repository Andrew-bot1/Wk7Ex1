using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static Wk7Ex1.Program;

namespace Wk7Ex1
{
    internal class Program
    {
        //create class for book
        public class Book
        {
            //properties of book
            public string Title { get; set; }
            public string Author { get; set; }
            public string Genre { get; set; }
            public double Price { get; set; }
        }

        static void Main(string[] args)
        {
            //create 7 books and give the properties
            Book book1 = new Book
            {
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                Genre = "Fiction",
                Price = 15.99
            };

            Book book2 = new Book
            {
                Title = "1984",
                Author = "George Orwell",
                Genre = "Dystopian",
                Price = 12.99
            };

            Book book3 = new Book
            {
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                Genre = "Romance",
                Price = 9.99
            };

            Book book4 = new Book
            {
                Title = "Moby Dick",
                Author = "Herman Melville",
                Genre = "Adventure",
                Price = 18.99
            };

            Book book5 = new Book
            {
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald ",
                Genre = "Fiction",
                Price = 10.99
            };

            Book book6 = new Book
            {
                Title = "Brave New World",
                Author = "Aldous Huxley",
                Genre = "Dystopian",
                Price = 14.99
            };

            Book book7 = new Book
            {
                Title = "War and Peace ",
                Author = "Leo Tolstoy ",
                Genre = "Historical Fiction",
                Price = 25.99
            };
            //create list of books
            List<Book> bookList = new List<Book>() { book1, book2, book3, book4, book5, book6, book7 };

            
            //query for finding books that cost more than $12
            Console.WriteLine("1. Books that cost more than $12: ");
            var cost = from s in bookList
                         where s.Price > 12
                         select s;

                    foreach (var var in cost)
                    {
                        Console.WriteLine(var.Title);
                    }


            //query for sorting books by price
            //declare count variable
            int count = 1;
            Console.WriteLine("2. Books in order of price: ");
            var price = from s in bookList
                         select s;
            while (count <= 7)
            {
                foreach (var var in price)
                {
                    if 
                    count++;
                }
                Console.WriteLine(
            }
           
        }
    }
}
