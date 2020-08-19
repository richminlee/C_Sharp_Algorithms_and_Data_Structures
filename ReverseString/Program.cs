using System;

namespace ReverseString
{
    class Program
    {
        public static char[] ReverseString(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;
            char temp;
            while (left < right)
            {
                temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                left++;
                right--;
            }
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString(new char[] { 'h', 'e', 'l', 'l', 'o' })); 
        }
    }
}
