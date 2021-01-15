using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System;
using mosh_csharp_basic.Debugging;

namespace mosh_csharp_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            CallStackWindow callStackWindow = new CallStackWindow();
            callStackWindow.GetStack();
        }

    }
}
