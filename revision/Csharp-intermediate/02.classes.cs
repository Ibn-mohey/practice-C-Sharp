using System;

namespace Csharp_intermediate
{
    public class Person
    {
        public string Name;

        public void Introduce(string to = "Mohey")
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        // create person object from string
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }

    public class Lesson_2
    {
        public static void demo()
        {
            var person = new Person();
            person.Name = "mohey";
            person.Introduce("mohey2");

            var p = Person.Parse("mohey3");
            p.Introduce();
        }

        public static void demo2()
        {
            Customer customer = new Customer();
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var order1 = new Order();
            customer.Orders.Add(order1);
        }
    }
}