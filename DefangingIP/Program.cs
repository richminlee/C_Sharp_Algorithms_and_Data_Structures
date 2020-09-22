using System;
using System.Linq;

namespace DefangingIP
{
    class Program
    {
        public static string DefangIPaddr(string address)
        {
            string[] splitString = address.Split(".");
            string result = String.Join("[.]", splitString);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DefangIPaddr("192.168.254.2"));
        }
    }
}
