using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosh_csharp_intermediate.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            text.Width = 100;
            text.Copy();

            Text text2 = new Text
            {
                Width = 100
            };
            text.Copy();
        }
    }
}
