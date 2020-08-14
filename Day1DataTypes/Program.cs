using System;

namespace Day1DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int j;
            double e;
            string t;

            // Read and save an integer, double, and String to your variables.
            j = int.Parse(Console.ReadLine());
            e = Convert.ToDouble(Console.ReadLine());
            t = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(j + i);

            // Print the sum of the double variables on a new line.
            Console.WriteLine(String.Format("{0:0.0}", (e + d)));

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + t);
        }
    }
}
