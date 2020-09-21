using System;
using System.Collections.Generic;
using System.Globalization;

namespace HappyNumber
{
    class Program
    {
        //public static bool squareDigits(int input, HashSet<int> hashInt)
        //{
        //    int digits = 0;
        //    while (input > 0)
        //    {
        //        digits += (input % 10) * (input % 10);
        //        input /= 10;
        //    }
        //    if (digits == 1)
        //    {
        //        return true;
        //    }
        //    if (hashInt.Contains(digits))
        //    {
        //        return false;
        //    }
        //    hashInt.Add(digits);
        //    return squareDigits(digits, hashInt);
        //}
        //public static bool IsHappy(int n)
        //{
        //    HashSet<int> list = new HashSet<int>();
        //    return squareDigits(n, list);  
        //}

        public static bool IsHappyHelper(int n, HashSet<int> results)
        {
            int digits = 0;
            while (n > 0)
            {
                digits += (n % 10) * (n % 10);
                n /= 10;
            }
            if (digits == 1)
            {
                return true;
            }
            if (results.Contains(digits))
            {
                return false;
            }
            results.Add(digits);
            return IsHappyHelper(digits, results);
        }
        public static bool IsHappy(int n)
        {
            HashSet<int> results = new HashSet<int>();
            return IsHappyHelper(n, results);

        }


        static void Main(string[] args)
        {
            Console.WriteLine(IsHappy(19));
            Console.WriteLine(IsHappy(92));
        }
    }
}
