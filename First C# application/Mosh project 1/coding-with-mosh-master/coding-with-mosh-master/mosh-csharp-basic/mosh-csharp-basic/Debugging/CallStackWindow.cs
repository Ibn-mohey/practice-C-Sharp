using System;
using System.Collections.Generic;

namespace mosh_csharp_basic.Debugging
{
    class CallStackWindow
    {
        public void GetStack()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6};
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);
        }

        public List<int> GetSmallests(List<int> list, int count)
        {
            if (count > list.Count)
            {
                throw new ArgumentOutOfRangeException("count", "Count should be between 1 and the number of elements in the list");
            }

            var buffer = new List<int>(list);
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }

            return smallests;
        }

        public int GetSmallest(List<int> list)
        {
            // Assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
    
}
