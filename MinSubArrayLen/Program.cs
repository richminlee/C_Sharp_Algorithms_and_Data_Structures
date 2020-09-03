using System;
using System.Diagnostics.CodeAnalysis;

namespace MinSubArrayLen
{
    class Program
    {
        public static int MinSubArrayLen(int[] input, int target)
        {
            int idx1 = 0;
            int idx2 = 1;
            int sum = input[0];
            int len = 0;
            while(idx2 != input.Length)
            {
                if(sum >= target)
                {
                    if (len > idx2 - idx1 + 1) len += idx2 - idx1 + 1;
                    sum -= input[idx1];
                    idx1++;
                }
                else
                {

                    sum += input[idx2];
                    idx2++;
                }
            }
            return len;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MinSubArrayLen(new int[] { 2,1,6,5,4}, 9));
        }
    }
}
