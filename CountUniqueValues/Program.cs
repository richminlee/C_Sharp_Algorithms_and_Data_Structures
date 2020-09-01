using System;

namespace CountUniqueValues
{
    class Program
    {
        public static int CountUniqueValues(int[] input)
        {
            int result = 1;
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
                    result++;
                    left = right;
                    right++;
                }

            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountUniqueValues(new int[] {-2,-1,-1,0,1 }));
        }
    }
}
