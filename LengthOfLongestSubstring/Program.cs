using System;
using System.Collections.Generic;

namespace LengthOfLongestSubstring
{
    class Program
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int resultidx = 0;
            int loopIdx = 0;
            var resultList = new List<int>();
            resultList.Add(0);
            var hashMap = new Dictionary<char, int>();
            for(int i = 0; i< s.Length; i++)
            {
                if (hashMap.ContainsKey(s[i]))
                {
                    loopIdx++;
                    i = loopIdx;
                    hashMap.Clear();
                    hashMap.Add(s[i], 1);
                    resultList.Add(1);
                    resultidx++;
                }
                else
                {
                    hashMap.Add(s[i], 1);
                    resultList[resultidx]++;
                }
            }
            int result = resultList[0];
            for (int i = 0; i < resultList.Count; i++)
            {
                if(resultList[i] > result)
                {
                    result = resultList[i];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLongestSubstring("dvdf"));
        }
    }
}
