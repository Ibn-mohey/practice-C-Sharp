using System.Collections.Generic;

namespace Mosh_project_1.Intermediate
{
    public class Customer
    {
        public int Id;
        public string Name;

        public readonly List<Order> Orderslist = new List<Order>();

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
        }


    }
}