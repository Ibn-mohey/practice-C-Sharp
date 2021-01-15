using System;

namespace mosh_csharp_intermediate.AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1994, 5, 22));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
