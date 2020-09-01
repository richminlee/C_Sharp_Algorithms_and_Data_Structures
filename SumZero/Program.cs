using System;

namespace SumZero
{
    class Program
    {
        public static int[] SumZero(int[] input)
        {
            int[] Result = new int[2];
            int left = 0;
            int right = input.Length - 1;
            while(left < right)
            {
                if(input[left] + input[right] == 0)
                {
                    Result[0] = input[left];
                    Result[1] = input[right];
                    return Result;
                }
                else if(input[left] + input[right] > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return Result;
        }
        static void Main(string[] args)
        {
            var Result = SumZero(new int[] { -4, -3, -2, 0, 1, 5 });
            foreach (var num in Result)
            {
                Console.Write($"{num},");
            }
        }
    }
}
