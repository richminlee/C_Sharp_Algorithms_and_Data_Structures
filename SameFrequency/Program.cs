using System;
using System.Collections.Generic;

namespace SameFrequency
{
    class Program
    {
        public static bool SameFrequency(int input1, int input2)
        {
            string StringInput1 = input1.ToString();
            string StringInput2 = input2.ToString();
            if (StringInput1.Length != StringInput2.Length) return false;
            Dictionary<char, int> DictInput1 = new Dictionary<char, int>();
            for (int i = 0; i < StringInput1.Length; i++)
            {
                if (!DictInput1.ContainsKey(StringInput1[i]))
                {
                    DictInput1.Add(StringInput1[i], 1);
                }
                else
                {
                    DictInput1[StringInput1[i]]++;
                }
            }
            for (int i = 0; i < StringInput2.Length; i++)
            {
                if (!DictInput1.ContainsKey(StringInput2[i]) || DictInput1[StringInput2[i]] == 0) return false;
                else
                {
                    DictInput1[StringInput2[i]]--;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SameFrequency(221,222));
        }
    }
}
