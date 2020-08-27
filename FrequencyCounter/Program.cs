using System;
using System.Collections.Generic;

namespace FrequencyCounter
{
    class Program
    {
        public static bool Same(int[] arr1, int[] arr2)
        {
            if(arr1.Length != arr2.Length)
            {
                return false;
            }
            var frequencyCounter1 = new Dictionary<int, int>();
            var frequencyCounter2 = new Dictionary<int, int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                if(!frequencyCounter1.ContainsKey(arr1[i]))
                {
                    frequencyCounter1.Add(arr1[i], 1);
                }
                else
                {
                    frequencyCounter1[arr1[i]]++;
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                if (!frequencyCounter2.ContainsKey(arr2[i]))
                {
                    frequencyCounter2.Add(arr2[i], 1);
                }
                else
                {
                    frequencyCounter2[arr2[i]]++;
                }
            }
            foreach(var pair in frequencyCounter1)
            {
                if (!frequencyCounter2.ContainsKey(pair.Key * pair.Key))
                {
                    return false;
                }
                if(frequencyCounter2[pair.Key * pair.Key] != frequencyCounter1[pair.Key])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Same(new int[] { 1, 2, 5, 3, 2 }, new int[] { 9, 1, 25, 4, 4 }));
        }
    }
}
