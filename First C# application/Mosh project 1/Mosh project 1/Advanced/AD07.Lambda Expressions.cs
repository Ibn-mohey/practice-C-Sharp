using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_project_1.Advanced
{

    class AD07
    {
        public class Book
        {
            public string Isbn { get; set; }
            public string Title { get; set; }
            public float Price { get; set; }
        }


        public class BookRepository
        {
            public List<Book> GetBooks()
            {
                return new List<Book>
                {
                    new Book() {Title = "Title 1", Price = 5},
                    new Book() {Title = "Title 2", Price = 7},
                    new Book() {Title = "Title 3", Price = 17}
                };
            }
        }

        static bool IsCheaperThan10Dollars(Book b1)
        {
            return b1.Price < 10;

        }

        public static void Run()
        {

            // arg => expression
            // num => num * num;
            // () => ...
            //  x => ...
            // (x,y,z) => ...



            //Func <elemnt returnvalue>
            //Func<int, int> square = numb => numb * numb;
            // Console.WriteLine(square(5));
            // const int factor = 5;
            // Func<int, int> multipler = n => n * factor;
            // Console.WriteLine(multipler(10));


            var books = new BookRepository().GetBooks(); // get the list of books

            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);

            var cheapBooks2 = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks2)
            {
                Console.WriteLine(book.Title);
            }
            // both work landa operator is less code 
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }


        }

        // static int Square(int number)
        // {
        //     return number * number;
        // }
    }
}
