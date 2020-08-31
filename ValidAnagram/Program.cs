using System;
using System.Collections.Generic;

namespace ValidAnagram
{
    class Program
    {
        public static bool ValidAnagram(string input1, string input2)
        {
            if (input1.Length != input2.Length) return false;

            var string1Dictionary = new Dictionary<char, int>();
            for (int i = 0; i < input1.Length; i++)
            {
                
                if (string1Dictionary.ContainsKey(input1[i]))
                {
                    string1Dictionary[input1[i]]++;
                }
                else
                {
                    string1Dictionary.Add(input1[i], 1);
                }
            }
            for (int i = 0; i < input2.Length; i++)
            {
                if (!string1Dictionary.ContainsKey(input2[i]) || string1Dictionary[input2[i]] == 0)
                {
                    return false;
                }
                string1Dictionary[input2[i]]--;
            }           
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ValidAnagram("a","ab"));
        }
    }
}
