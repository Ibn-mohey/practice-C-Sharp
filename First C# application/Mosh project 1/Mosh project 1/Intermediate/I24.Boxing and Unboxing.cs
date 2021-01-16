using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_project_1.Intermediate
{
    class I24
    {
        public static void Run()
        {
            var listobj = new ArrayList();
            listobj.Add(1); // here we pass an int which is a value there fore the boxing with happen
            listobj.Add("mosh"); // here we pass string which is an obj therefor no boxing will happen
            listobj.Add(DateTime.Today);

            var numm = (int) listobj[1];
            var anotherlist = new List<int>();
            anotherlist.Add(2); // no boxing will happen as the list strores values (int) not objects 


        }
    }
}
