using System;
using System.Collections.Generic;

namespace ValidAnagram
{
    class Program
    {
        public static bool ValidAnagram(string input1, string input2)
        {
            var string1Dictionary = new Dictionary<char, int>();
            var string2Dictionary = new Dictionary<char, int>();
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
                if (string2Dictionary.ContainsKey(input2[i]))
                {
                    string2Dictionary[input2[i]]++;
                }
                else
                {
                    string2Dictionary.Add(input2[i], 1);
                }
            }
            foreach(var num in string1Dictionary)
            {
                if (!string2Dictionary.ContainsKey(num.Key) || string2Dictionary[num.Key] != num.Value)
                {
                    return false;
                }
            }            
            foreach(var num in string2Dictionary)
            {
                if (!string1Dictionary.ContainsKey(num.Key) || string1Dictionary[num.Key] != num.Value)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ValidAnagram("a","ab"));
        }
    }
}
