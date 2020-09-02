using System;
using System.Security.Cryptography;

namespace AveragePair
{
    class Program
    {
        public static bool AveragePair(int[] input, double target)
        {
            int left = 0;
            int right = input.Length - 1;
            while (left < right)
            {
                if ((double)(input[left]) + (double)(input[right]) / 2 == target) return true;
                else if ((double)(input[left]) + (double)(input[right]) / 2 < target) left++;
                else right--;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(AveragePair(new int[] { 1,3,3,5,6,7,10,12,19}, 8));
        }
    }
}
