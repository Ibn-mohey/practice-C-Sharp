using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosh_csharp_basic.control_flow
{
    class switches //use switch for check your variables
    {
        public void Switches()
        {
            Enum season = Season.Autumn;
            switch (season)
            {
                //case Season.Autumn:
                //    Console.WriteLine("It's autumn and a beautiful season.");
                //    break;

                //case Season.Summer:
                //    Console.WriteLine("It's perfect to go to beach");
                //    break;

                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got promotion");
                    break;
                default:
                    Console.WriteLine("I don't understand that season");
                    break;
            }
        }
    }
}
