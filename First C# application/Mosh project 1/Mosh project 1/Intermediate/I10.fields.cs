using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mosh_project_1.Intermediate;

namespace Mosh_project_1.Intermediate
{
    class I10
    {
        public static void Run()
        {
            var Cust = new Customer(1);
            Cust.Orderslist.Add(new Order());
            Cust.Orderslist.Add(new Order());
            Console.WriteLine(Cust.Orderslist.Count);

        }
    }
}
