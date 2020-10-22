using System;
using System.Collections.Generic;

namespace FindWords
{
    class Program
    {
        public static string[] FindWords(string[] words)
        {
            HashSet<char> keyBoardRow1 = new HashSet<char>() { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P' };
            HashSet<char> keyBoardRow2 = new HashSet<char>() { 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L' };
            HashSet<char> keyBoardRow3 = new HashSet<char>() { 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };
            List<string> result = new List<string>();
            static void checkKeyboard(string[] words, HashSet<char> keyBoard, List<string> result)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    bool check = false;
                    string upperWords = words[i].ToUpper();
                    for (int j = 0; j < upperWords.Length; j++)
                    {
                        if (keyBoard.Contains(upperWords[j]) == false)
                        {
                            check = true;
                            break;
                        }
                    }
                    if (check == false)
                    {
                        result.Add(words[i]);
                    }
                }

            }
            checkKeyboard(words, keyBoardRow1, result);
            checkKeyboard(words, keyBoardRow2, result);
            checkKeyboard(words, keyBoardRow3, result);
            return result.ToArray();
        }
        static void Main(string[] args)
        {
            string[] result = FindWords(new string[] { "Hello", "Alaska", "Dad", "Peace" });
            foreach (string temp  in result)
            {
                Console.WriteLine(temp);

            }

        }
    }
}
