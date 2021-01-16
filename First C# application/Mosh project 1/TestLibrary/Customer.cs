using System;
using System.Collections.Generic;

namespace TestLibrary
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //public readonly List<Order> Orderslist = new List<Order>();

        // parameter less 
        public Customer()
        {
            //Orderslist = new List<Order>(); // so it doesn't  start at null 
        }
        // if i did not create constructor C# create one for us 
        public Customer(int id)
        : this()
        {
            this.Id = id;
        }

        public Customer(int id , string name)
            : this(id)
        {
            this.Name = name;

        }

        public void Promote()
        {
           // Orderslist = new List<Order>();
           var rating = CalculateRating();
           if(rating == 0)
               Console.WriteLine("lvl 1");
           else
               Console.WriteLine("lvl 2");
        }

        private int CalculateRating()
        {
            return 0;
        }

    }
}