using System;
using System.Collections.Generic;

namespace sockMerchant
{
    class Program
    {
        static int sockMerchant(int n, int[] ar)
        {
            Dictionary<int, int> socks = new Dictionary<int, int>();
            for (int i = 0; i < ar.Length; i++)
            {
                if (socks.ContainsKey(ar[i])) socks[ar[i]]++;
                else
                {
                    socks.Add(ar[i], 1);
                }
            }
            int result = 0;
            foreach (var num in socks.Values)
            {
                result += num / 2;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(sockMerchant(9,new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }));
        }
    }
}
