using System;

namespace PlusOne
{
    class Program
    {
        public static int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (i == 0 && digits[i] == 9)
                {
                    var newDigits = new int[digits.Length + 1];
                    newDigits[0] = 1;
                    return newDigits;
                }
                else if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i]++;
                    break;
                }
            }
            return digits;
        }
        static void Main(string[] args)
        {
            int[] digits = PlusOne(new int[] { 9,8,7,6,5,4,3,2,1,0});
            foreach (var num in digits)
            {
                Console.Write(num);
            }
        }
    }
}
