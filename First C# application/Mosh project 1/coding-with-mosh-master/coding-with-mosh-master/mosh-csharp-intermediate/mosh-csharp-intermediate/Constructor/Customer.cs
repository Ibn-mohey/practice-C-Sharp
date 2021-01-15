using System.Collections.Generic;

namespace mosh_csharp_intermediate.Constructor
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id)
            :this() //initalize the Customer() first
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            :this(id) //initalize the id first
        {
            this.Name = name;
        }
    }
}
