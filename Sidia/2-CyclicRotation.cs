using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/

namespace Sidia
{
    class CyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            if (A.Length == 0) { return A; }

            int tmp;
            for (int i = 0; i < K; i++)
            {
                tmp = A[A.Length-1];

                for (int j = A.Length-1; j > 0; j--)
                {
                    A[j] = A[j - 1];
                }
                A[0] = tmp;
            }

            return A;
        }
    }
}
