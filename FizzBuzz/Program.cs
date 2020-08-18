using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        public static List<string> FizzBuzz(int n)
        {
            var resultString = new List<string>();
            for(int i = 1; i<=n; i++ )
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    resultString.Add("FizzBuzz");
                }                
                else if(i % 3 == 0)
                {
                    resultString.Add("Fizz");
                }                
                else if(i % 5 == 0)
                {
                    resultString.Add("Buzz");
                }                
                else
                {
                    resultString.Add($"{i}");
                }
            }
            return resultString;
        }
        static void Main(string[] args)
        {
            var result = FizzBuzz(15);
            foreach(var key in result)
            {
                Console.WriteLine(key);
            }
        }
    }
}
