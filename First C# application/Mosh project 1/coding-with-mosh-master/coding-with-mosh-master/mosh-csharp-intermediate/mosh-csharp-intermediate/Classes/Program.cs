using System;

namespace mosh_csharp_intermediate.Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        //public Person Parse(string str)
        //{
        //    var person = new Person();
        //    person.Name = str;

        //// alternative way
        //    //var person = new Person
        //    //{
        //    //    Name = str
        //    //};

        //    return person;
        //}

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            //// alternative way
            //var person = new Person
            //{
            //    Name = str
            //};

            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //var person = new Person();

            //person.Name = "Peter";
            Person person = Person.Parse("Peter"); //calling a static method
           
            person.Introduce("Mosh");
        }
    }
}
