using System;

namespace IsSubsequence
{
    class Program
    {
        public static bool IsSubsequence(string first, string second)
        {
            int idx1 = 0;
            int idx2 = 0;
            while(idx1 != first.Length && idx2 != second.Length)
            {
                if (idx1 == first.Length - 1 && first[idx1] == second[idx2]) return true;
                else if (first[idx1] == second[idx2]) idx1++;
                else idx2++;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsSubsequence("abc", "acb"));
        }
    }
}
