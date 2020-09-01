using System;
using System.IO.MemoryMappedFiles;

namespace MaxSubArraySum
{
    class Program
    {
        public static int MaxSubArraySum(int[] input, int number)
        {
            int temp = 0;
            int left = 0;
            int right = 0;
            while (right != number)
            {
                temp += input[right];
                right++;
            }
            int result = temp;
            while(right != input.Length)
            {
                temp += input[right];
                temp -= input[left];
                if(result < temp)
                {
                    result = temp;
                }
                right++;
                left++;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MaxSubArraySum(new int[] { 999,2,1,6,1}, 4 ));
        }
    }
}
