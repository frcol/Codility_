using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/

namespace Codility_
{
    public class OddOccurrencesInArray
    {
        public int solution(int[] A)
        {
            int unpaired = 0;
            int oldUnpaired = 0;

            foreach (int element in A)
            {
                oldUnpaired = unpaired;
                
                

                // Console.Write("["+unpaired+ "] "+ Convert.ToString(unpaired,2));
                //Console.WriteLine(" = [" + element + "] " + Convert.ToString(element, 2));

                unpaired = unpaired^element;

                //Console.WriteLine("[" + unpaired + "] "+Convert.ToString(unpaired, 2));
                Console.Write(Convert.ToString(unpaired, 2) + " = ");
                Console.Write(Convert.ToString(oldUnpaired, 2) + " ^ ");
                Console.WriteLine(Convert.ToString(element, 2));
            }

            return unpaired;
        }
    }
}
