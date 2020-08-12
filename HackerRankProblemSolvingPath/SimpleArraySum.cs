using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankProblemSolvingPath
{
    class SimpleArraySum
    {
        static int simpleArraySum(int[] ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            return sum;
        }
    }
}
