using System;
using System.Collections.Generic;

namespace CountPrime
{
    class Program
    {
        public static int CountPrimes(int n)
        {
            int result = 0;
            if (n > 2) result++;
            for (int i = 3; i < n; i += 2)
            {
                int count = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    if (j >= Math.Sqrt(i))
                    {
                        count++;
                        break;
                    }
                }
                if (count > 0) result++;
            }
            return result;
            //bool isPrime = true;
            //List<int> prime = new List<int>();
            //if (n > 2) prime.Add(2);
            //for (int i = 3; i <n; i+=2)
            //{
            //    for (int j = 0; j < prime.Count; j++)
            //    {
            //        if (i % prime[j] == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //        else isPrime = true;
            //    }
            //    if (isPrime == true)
            //    {
            //        prime.Add(i);
            //    }
            //}
            //return prime.Count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountPrimes(499954));
        }
    }
}
/*
 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 
53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 
113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 
191, 193, 197, 199,
 */