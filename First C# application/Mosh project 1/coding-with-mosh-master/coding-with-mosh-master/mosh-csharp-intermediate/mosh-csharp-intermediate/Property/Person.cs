using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosh_csharp_intermediate.Property
{
    class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }
        //public DateTime Birthdate { get; set; }
        public DateTime Birthdate { get; private set; } //To only allow the age to be set once

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                TimeSpan timespan = DateTime.Today - Birthdate;
                int years = timespan.Days / 365;

                return years;
            }
        }


    }
}
