using System;
using System.Drawing;

namespace AreaOfCircle
{
    class Program
    {
        public static int AreaOfCircle(int[] one, int[] two)
        {
            double Diameter = Math.Sqrt((Math.Pow((two[0] - one[0]), 2) + Math.Pow((two[1] - one[1]), 2)));
            double result = Math.PI * Math.Pow((Diameter / 2), 2);
            return (int)result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(AreaOfCircle(new int[] { -1, -2}, new int[] { 1, 2}));
        }
    }
}

/*
 * area of a circle = pi * r ^2
 * 
 * distance of 2 points = sqrt((x2 - x1)^2 + (y2 - y1)^2)
 * 
 * input 2 points
 * 
 * output  = int
 * 
 * 
 * 
 * 
 * 
 * 
 */
