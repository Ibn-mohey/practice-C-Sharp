using System;
using System.Collections.Generic;

namespace mosh_csharp_intermediate.Indexers
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dirctionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dirctionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get{ return _dirctionary[key];}
            set { _dirctionary[key] = value;}
        }

        public void SetItem(string key, string value)
        {

        }

        public void GetItem(string key, string value)
        {

        }
    }
}
