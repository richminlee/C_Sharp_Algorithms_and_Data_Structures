using System;
using System.Collections.Generic;

namespace FirstUniqueChar
{
    class Program
    {
        public static int FirstUniqChar(string s)
        {
            Dictionary<char, int> charDict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (charDict.ContainsKey(s[i]))
                {
                    charDict[s[i]] = -1;
                }
                else
                {
                    charDict.Add(s[i], i);
                }
            }
            int result = int.MaxValue;
            foreach(var temp in charDict)
            {
                if(temp.Value > -1 && temp.Value < result)
                {
                    result = temp.Value;
                }
            }
            if(result == int.MaxValue)
            {
                return -1;
            }
            return result;
        }
    
        static void Main(string[] args)
        {
            Console.WriteLine(FirstUniqChar("loveleetcode"));
        }
    }
}
