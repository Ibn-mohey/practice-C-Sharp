using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_project_1.Intermediate
{



    public class HttpCookie
    {
        private readonly Dictionary<string, string>  _dictionary;
        public DateTime Expire { get; set; }


        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }





    /* program */
    public class I13
    {
        public static void Run()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "mohey";
            Console.WriteLine(cookie["name"]);


        }


    }
    
}
