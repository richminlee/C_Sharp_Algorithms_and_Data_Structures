using System;
using System.Collections.Generic;

namespace VowelsFromString
{
    class Program
    {
        public static int VowelsFromString(string input)
        {
            string lowerCaseInput = input.ToLower();
            int result = 0;
            int yResult = 0;
            var VowelsDict = new Dictionary<char, int>();
            VowelsDict.Add('a', 1);
            VowelsDict.Add('e', 1);
            VowelsDict.Add('i', 1);
            VowelsDict.Add('o', 1);
            VowelsDict.Add('u', 1);
            for(int i = 0; i < input.Length; i++)
            {
                if (VowelsDict.ContainsKey(lowerCaseInput[i])) result++;
                if (lowerCaseInput[i] == 'y') yResult++;
            }
            if (result == 0) result = yResult;
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(VowelsFromString("you"));
        }
    }
}
