using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidia
{
    class SmallestInteger
    {
        public int solution(int[] A)
        {
            HashSet<int> set = new HashSet<int>();

            // Store all positive integers in the set
            foreach (int num in A)
            {
                if (num > 0)
                {
                    set.Add(num);
                }
            }

            Console.WriteLine(string.Join(", ", set));

            // Find the smallest positive integer that does not occur in A
            int smallestMissing = 1;
            while (set.Contains(smallestMissing))
            {
                smallestMissing++;
            }

            return smallestMissing;
        }
    }
}
