using System;

namespace Sqrt
{
    class Program
    {
        public static int MySqrt(int x)
        {
            int result = (int)Math.Pow(x, 0.5);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MySqrt(4));
        }
    }
}
