using System;

namespace CountUniqueValues
{
    class Program
    {
        public static int CountUniqueValues(int[] input)
        {
            int left = 0;
            int right = 1;
            while(right != input.Length)
            {
                if(input[left] == input[right])
                {
                    right++;
                }
                else
                {
                    left++;
                    input[left] = input[right];
                    right++;
                }

            }
            return left+1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountUniqueValues(new int[] {1,2,3,4,4,4,7,7,12,12,13}));
        }
    }
}
