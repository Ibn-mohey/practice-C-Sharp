using System.Collections.Generic;

namespace Csharp_intermediate
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()

        {
            // we do that in every generic list so we dont face add to null program
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this()

        {
            this.Id = id;
            this.Name = name;
        }
    }
}