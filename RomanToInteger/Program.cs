using System;
using System.Collections.Generic;

namespace RomanToInteger
{
    class Program
    {
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanDictionary = new Dictionary<char, int>()
            {
                { 'I',1 },{ 'V',5 },{ 'X',10 },{ 'L',50 },{ 'C',100 },{ 'D',500 },{'M', 1000}
            };
            int result = romanDictionary[s[s.Length - 1]];
            char idx = s[s.Length-1];
            for (int i = s.Length-2; i >= 0 ; i--)
            {
                if(romanDictionary[s[i]] >= romanDictionary[idx])
                {
                    result += romanDictionary[s[i]];
                }
                else
                {
                    result -= romanDictionary[s[i]];
                }
                idx = s[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("LVIII"));
        }
    }
}
