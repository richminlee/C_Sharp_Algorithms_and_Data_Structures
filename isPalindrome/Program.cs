using System;

namespace isPalindrome
{
    class Program
    {
        public static bool FindPalindrome(string input)
        {
            input = input.ToLower();
            int i = 0;
            int j = input.Length - 1;
            while (j > i)
            {
                while (input[i] < 'a' || input[i] > 'z')
                {
                    i++;
                }
                while (input[j] < 'a' || input[j] > 'z')
                {
                    j--;
                }
                if (input[i] != input[j])
                {
                    return false;
                }
                i++;
                j--;
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindPalindrome(".,"));
        }
    }
}
