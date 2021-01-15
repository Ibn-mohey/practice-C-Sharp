using System;

namespace mosh_csharp_basic
{
    public class StructPerson
    {
        //**Add to Main()

        //StructPerson peter = new StructPerson(); //Non-Primitive needs to be give memory to it
        //peter.FirstName = "Peter";
        //peter.LastName = "Coker";
        //peter.Introduce();

        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            //Console.WriteLine("My name is " + FirstName + " " + LastName );
            Console.WriteLine("My name is {0} {1}", FirstName, LastName);
        }
    }
}
