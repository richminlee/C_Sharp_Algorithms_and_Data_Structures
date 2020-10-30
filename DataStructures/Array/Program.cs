using System;
using System.Linq;
using System.Text;

namespace Array
{
    class Program
    {
        static string reverseString(string input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result.Append(input[i]);
            }
            return result.ToString();
        }
        static int[] mergeSortedArray(int[] one, int[] two)
        {
            if (one.Length == 0) return two;
            if (two.Length == 0) return one;
            int[] result = new int[one.Length + two.Length];
            int i = 0;
            int j = 0;
            int k = 0;
            while (k < result.Length)
            {
                if(j >= two.Length || one[i] <= two[j])
                {
                    result[k] = one[i];
                    k++;
                    i++;
                }
                else
                {
                    result[k] = two[j];
                    k++;
                    j++;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(reverseString("Hello World!"));

            int[] result = mergeSortedArray(new int[]{ 0, 3, 4, 31}, new int[]{ 4, 6, 30});
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
