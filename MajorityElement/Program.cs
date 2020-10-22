using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace MajorityElement
{
    class Program
    {
        //public static int MajorityElement(int[] nums)
        //{
        //    Dictionary<int, int> numsDict = new Dictionary<int, int>();
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (numsDict.ContainsKey(nums[i]))
        //        {
        //            numsDict[nums[i]]++;
        //        }
        //        else
        //        {
        //            numsDict.Add(nums[i], 1);
        //        }
        //    }
        //    int compare = 0;
        //    int result = 0;
        //    foreach (int num in numsDict.Keys)
        //    {
        //        if (compare < numsDict[num])
        //        {
        //            compare = numsDict[num];
        //            result = num;
        //        }
        //    }
        //    return result;
        //}
        //public static int majorityElement(int[] nums)
        //{
        //    int count = 0;
        //    int result = 0;

        //    foreach (int num in nums)
        //    {
        //        if (count == 0)
        //        {
        //            result = num;
        //        }
        //        if (num == result) 
        //        {
        //            count++;        
        //        }
        //        else
        //        {
        //            count--;
        //        }
        //    }

        //    return result;
        //}

        public static int majorityElement(int[] nums)
        {
            int count = 0;
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    result = nums[i];
                }
                if (nums[i] == result)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(majorityElement(new int[] { 2,2,1,1,1,2,2}));
        }
    }
}
