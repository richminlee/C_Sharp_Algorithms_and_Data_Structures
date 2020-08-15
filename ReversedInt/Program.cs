using System;

namespace ReversedInt
{
    class Program
    {
        static int reverseInt(int inputInt)
        {
            int reversedInt = 0;
            while (inputInt > 0)
            {
                if (reversedInt != 0) reversedInt *= 10;
                reversedInt += inputInt % 10;
                inputInt /= 10;
            }
            return reversedInt;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(reverseInt(1234));
        }
    }
}
