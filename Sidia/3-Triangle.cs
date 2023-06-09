﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidia
{
    /*
    Let’s print a triangle made of asterisks (‘*’) separated by spaces and consisting
    of n rows again, but this time upside down, and make it symmetrical. Consecutive rows should
    contain 2n − 1, 2n − 3, . . . , 3, 1 asterisks and should be indented by 0, 2, 4, . . . , 2(n − 1)
    spaces. For example, for n = 4 the triangle should appear as follows:
    * * * * * * *
      * * * * *
        * * *
          *
    */
    class Triangle
    {
        public void solution(int n)
        {
            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < 2*(n-i); j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2*i-1; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
