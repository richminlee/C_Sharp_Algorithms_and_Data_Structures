using System;
using System.Collections.Generic;

namespace LongestString
{
    class Program
    {
        public static string LongestString(string input)
        {
            string result = "";
            string[] allStrings = input.Split(' ');
            for (int i = 0; i < allStrings.Length; i++)
            {
                if (result.Length < allStrings[i].Length)
                {
                    result = allStrings[i];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(LongestString("I am lost"));
        }
    }
}
