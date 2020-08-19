using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SingleNumber
{
    class Program
    {
        public static int SingleNumber(int[] nums)
        {
            var hash = new Dictionary<int, int>();
            int result = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (hash.ContainsKey(nums[i]))
                {
                    hash.Remove(nums[i]);
                }
                else
                {
                    hash.Add(nums[i], 1);
                }
                    
            }
            foreach(var num in hash)
            {
                result = num.Key;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SingleNumber(new int[] { 2, 2, 1 }));
        }
    }
}
