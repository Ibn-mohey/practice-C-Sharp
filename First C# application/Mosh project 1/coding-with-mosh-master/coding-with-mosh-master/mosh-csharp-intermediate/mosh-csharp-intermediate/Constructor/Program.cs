using System;

namespace mosh_csharp_intermediate.Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Peter";

            var Order = new Order();
            customer.Orders.Add(Order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            
        }
    }
}
