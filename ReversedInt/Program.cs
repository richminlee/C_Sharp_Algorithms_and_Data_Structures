using System;

namespace ReversedInt
{
    class Program
    {
        static int reverseInt(int inputInt)
        {
            try
            {
                int reversedInt = 0;
                while (inputInt != 0)
                {
                    if (reversedInt != 0) reversedInt = checked(reversedInt * 10);
                    reversedInt += inputInt % 10;
                    inputInt /= 10;
                }
                return reversedInt;
            }
            catch (System.OverflowException)
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(reverseInt(1534236469));
        }
    }
}
