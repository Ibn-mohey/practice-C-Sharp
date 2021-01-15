using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosh_csharp_basic.Reference_Type
{
    public class Persons
    {
        public int Age;
    }

    class referencetype
    {
        //**add the Main()
        //ReferenceType referenceType = new ReferenceType() {Age = 20};
        //MakeOld(referenceType);
        //Console.WriteLine(referenceType.Age);

        //int[] array1 = new int[3] {1, 2, 3};
        //int[] array2 = array1;

        //array2[0] = 0;
        //Console.WriteLine(string.Format("array1[0]: {0}, array[0]: {1}", array1[0], array2[0]));


        public void MakeOld(Persons person)
        {

            person.Age += 10;
            //Console.WriteLine(person.Age);
        }
    }
}
