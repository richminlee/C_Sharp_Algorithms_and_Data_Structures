using System;

namespace TwoSum
{
    class Program
    {
        //public static int[] TwoSum(int[] nums, int target)
        //{
        //    int[] Result = new int[2];
        //    for (int i = 0; i < nums.Length - 1; i++)
        //    {
        //        for (int j = i + 1; j < nums.Length; j++)
        //        {
        //            if (nums[i] + nums[j] == target)
        //            {
        //                Result[0] = i;
        //                Result[1] = j;
        //            }
        //        }
        //    }
        //    return Result;
        //}
        public static int[] TwoSum(int[] nums, int target)
        {
            int idx1 = 0;
            int idx2 = 1;
            int[] Result = new int[2];
            while (idx1 != nums.Length-1)
            {
                if(idx1 != idx2)
                {
                    if(nums[idx1] + nums[idx2] == target)
                    {
                        Result[0] = idx1;
                        Result[1] = idx2;
                        return Result;
                    }
                    else if(idx2 == nums.Length-1)
                    {
                        idx1++;
                        idx2 = idx1 + 1;
                    }
                    else
                    {
                        idx2++;
                    }
                }
            }
            return Result;
        }
        static void Main(string[] args)
        {
            int[]Result = TwoSum(new int[] {3,2,4}, 6);
            foreach(var num in Result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
