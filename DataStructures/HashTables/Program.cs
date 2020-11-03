using System;
using System.Collections.Generic;

namespace HashTables
{
    class Program
    {
        static int FirstDuplicate(int[] input)
        {
            HashSet<int> result = new HashSet<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (result.Contains(input[i]))
                {
                    return input[i];
                }
                else
                {
                    result.Add(input[i]);
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FirstDuplicate(new int[] { 2,3,4,5}));
        }
    }
}
