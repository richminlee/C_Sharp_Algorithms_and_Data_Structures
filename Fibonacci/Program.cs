using System;

namespace Fibonacci
{
    class Program
    {
        public static int Fib(int N)
        {
            if (N == 1) return 1;
            if (N == 0) return 0;
            return Fib(N - 1) + Fib(N - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(12));
        }
    }
}
