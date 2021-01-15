using System;

namespace mosh_csharp_basic.control_flow
{
    class conditional_statements
    {
        public void IfCondition()
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Tt's morning.");
            }

            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }

            else
            {
                Console.WriteLine("It's evening.");
            }
        }

        public void ConditionOperator()
        {
            bool isGoldCustomeer = true;
            //float price;

            //if (isGoldCustomeer)
            //{
            //    price = 19.95f;
            //}

            //else
            //{
            //    price = 29.95f;
            //}

            //float price = (isGoldCustomeer) ? 19.95f : 29.95f;

            //Console.WriteLine(price);
        }
    }
}
