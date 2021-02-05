using System;
using System.Text.RegularExpressions;

namespace CSharp
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Counting Valleys
            Console.WriteLine("Valley Count: " + new CountOfValleys().countingValleys());
        }
    }
}