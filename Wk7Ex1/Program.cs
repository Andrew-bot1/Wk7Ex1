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

            //output all books that cost more than $12
            foreach (var var in cost)
            {
                //output title for each book
                Console.WriteLine(var.Title);
            }


            //query for sorting books by price
            Console.WriteLine("2. Books orderd by price");
            var result = from s in bookList
                         orderby s.Price
                         select (s);

            //output all books in order of price
            foreach (var var in result)
            {
                //output title and price for each book
                Console.WriteLine($"{var.Title}, {var.Price}");
            }

            //query for sorting books by genre
            Console.WriteLine("3. Books orderd by price");
            var gen = from s in bookList
                         orderby s.Genre
                         select s;

            //output all books in order of price
            foreach (var var in gen)
            {
                //outpupt title and genre for each book
                Console.WriteLine($"{var.Title}, {var.Genre}");
            }

            //query for selecting only titles and authors
            Console.WriteLine("4. Books orderd by price");
            var pro = from s in bookList
                      select (s.Title, s.Author);

            //output all books in order of price
            foreach (var var in pro)
            {
                //output title and author for each book
                Console.WriteLine(var);
            }
        }
    }
}
