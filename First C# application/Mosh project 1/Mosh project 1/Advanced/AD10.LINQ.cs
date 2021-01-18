using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_project_1.Advanced
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "ADO.Net Step by Step", Price = 5 },
                new Book() {Title = "ASP.NET MVC", Price = 9.99f },
                new Book() {Title = "ASP.NET Web API", Price = 12 },
                new Book() {Title = "C# Advanced Topics", Price = 7 },
                new Book() {Title = "C# Advanced Topics", Price = 9 }
            };
        }
    }

    public class String
    {
        public void Shorten(int numberOfWords)
        {


        }

        public int Add(int a, int b)
        {
            return a + b;
        }


    }

    public class MessageArgs
    {
    }



    class AD10
    {
        public static void Run()
        {
            var books = new BookRepository().GetBooks();

            // var cheapbooks = new List<Book>();
            // foreach (var b in books)
            // {
            //     if (b.Price < 10) 
            //     {
            //         cheapbooks.Add(b);
            //     }
            // }

            // var cheapbooks =
            //     from b in books
            //     where b.Price < 10
            //     orderby b.Title
            //     select b;


            // var cheapbooks = books
            //                                     .Where(b => b.Price < 10)
            //                                     .OrderBy(b => b.Price)
            //                                     .Select(b => b.Title);

            // foreach (var b in cheapbooks)
            // {
            //     Console.WriteLine(b);
            //     // Console.WriteLine(b.Title + " " + b.Price);   
            // }
            //
            var book = books.SingleOrDefault(b => b.Price == 9f);
            // .First   .Last   .skip().take()  .count()    .Max(b=> b.Price)     .Min()    
            // .sum()       
            Console.WriteLine(book.Title);

        }


    }
}
