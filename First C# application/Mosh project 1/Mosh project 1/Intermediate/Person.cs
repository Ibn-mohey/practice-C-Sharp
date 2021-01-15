using System;

namespace Mosh_project_1
{
    /*  acccess class id */
    public class Person
    {
        // public string fname;
        // public string lname;
        // private DateTime _birthdate;
        // other way to do that 
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        public DateTime Birthdate { get; private set; }

        public int Age
        {
            get
            {
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;
                return years;
            }
            
        }

        // /*      access void name        */
        // public void intro() /* intro method ID by void and name of the method */
        //                     /* void doesnt return and doesnt take parms */
        // {
        //     Console.WriteLine("my name is " + fname + ' ' + lname);
        // }
        //
        // public void SetBirthdate(DateTime birthdate)
        // {
        //     _birthdate = birthdate;
        // }
        //
        // public DateTime Getbirthdate()
        // {
        //     return _birthdate;
        // }

        public static void Run()
        {

            var person1 = new Person(new DateTime(1996, 5, 31));
            Console.WriteLine(person1.Age);
        }
    }
}