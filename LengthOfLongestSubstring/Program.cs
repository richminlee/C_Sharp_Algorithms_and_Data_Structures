using System;
using System.Collections.Generic;

namespace LengthOfLongestSubstring
{
    class Program
    {
        public int LengthOfLongestSubstring(string s)
        {
            int result = 0;
            var hashMap = new Dictionary<string, int>();
            for(int i = 0; i< s.Length; i++)
            {
                if (!(hashMap[s[i]]))
                {

                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
