using System;

namespace WhiteboardingDuringClass
{
    class Program
    {
        public static int SumOfEven(int min, int max)
        {
            int result = 0;
            for (int i = min; i <= max; i++)
            {
                if(i % 2 == 0)
                {
                    result += i;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SumOfEven(1,10));
        }
    }
}
