using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_project_1.Intermediate
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("hi {0} i am {1}" , to , Name);
        }

        public Person Parsemethod(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
		public static Person ParseStatic(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }

    public class I01
    {
        public static void Run()
        {
            Console.WriteLine("classes run");
            var personObj = new Person(); // create the object 
            personObj.Name = "namess";
			personObj.Introduce("mohey");

			//
            var p = personObj.Parsemethod("test parse");
			p.Introduce("not static");
			//
            var pStatic = Person.ParseStatic("parse static");
			pStatic.Introduce("static ");






        }
    }
}
