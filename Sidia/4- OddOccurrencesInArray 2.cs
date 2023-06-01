using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/

namespace Codility_
{
    public class OddOccurrencesInArray2
    {
        public int solution(int[] A)
        {
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            // Contagem dos elementos na matriz
            foreach (int num in A)
            {
                if (countMap.ContainsKey(num))
                {
                    countMap[num]++;
                }
                else
                {
                    countMap[num] = 1;
                }
            }

            // Encontrar o elemento não emparelhado
            foreach (var pair in countMap)
            {
                if (pair.Value % 2 != 0)
                {
                    return pair.Key;
                }
            }

            // Caso não encontre o elemento não emparelhado
            throw new InvalidOperationException("No unpaired element found.");
        }
    }
}
