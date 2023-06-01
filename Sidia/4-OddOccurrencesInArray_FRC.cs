using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_
{
    public class OddOccurrencesInArray_FRC
    {
        public int solution(int[] A)
        {
            int odd = -1;

            for (int i = 0; i < A.Length; i++) // passo por cada item
            {
                if (A[i] != 0) // se for zero, ja teve par
                {
                    odd = A[i];  // senao, suponho que e o Odd
                }
                
                for (int j = i+1; j < A.Length; j++) // passo pelo restante do Array para achar o par
                {
                    if ((A[i] == A[j])) // achou o par
                    {
                        odd = -1; // seto odd para valor original
                        A[j] = 0; // substituo o par por 0
                        break;
                    }
                }

                if (odd != -1) // nao achei par, ele e o numero se par
                {
                    break;
                }
            }

            return odd;
        }
    }
}
