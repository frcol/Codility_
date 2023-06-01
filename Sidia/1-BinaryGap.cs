using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://app.codility.com/programmers/lessons/1-iterations/binary_gap/

namespace Sidia
{
    class BinaryGap
    {
        public int solution(int N)
        {
            string strBinary = Convert.ToString(N,2);
            int actualCount = 0;
            int max = 0;
            bool isCounting = false;

            foreach(char ch in strBinary)
            {
                if (ch == '1')
                {
                    if (isCounting && actualCount > max)
                    {
                        max = actualCount;
                    }

                    isCounting = true;
                    actualCount = 0;
                }
                else
                {
                    actualCount++;
                }
            }

            return max;
        }
    }
}
