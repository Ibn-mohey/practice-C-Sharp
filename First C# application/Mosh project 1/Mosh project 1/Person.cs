using System;

namespace Mosh_project_1
{
    /*  acccess class id */
    public class Person
    {
        public string fname;
        public string lname;

        /*      access void name        */
        public void Intro() /* intro method ID by void and name of the method */
                            /* void doesnt return and doesnt take parms */
        {
            Console.WriteLine("my name is " + fname + ' ' + lname);
        }

    }
}