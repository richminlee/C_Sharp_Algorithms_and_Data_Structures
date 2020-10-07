using System;
using System.Linq;

namespace ReverseWords
{
    class Program
    {
        public static string ReverseWords(string s)
        {
            string[] splitString = s.Split(" ");
            for (int i = 0; i < splitString.Length; i++)
            {
                string temp = "";
                for (int j = splitString[i].Length-1; j >= 0; j--)
                {
                    temp += splitString[i][j];
                }
                splitString[i] = temp;
            }
            return String.Join(" ", splitString);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("Let's take LeetCode contest"));
        }
    }
}
