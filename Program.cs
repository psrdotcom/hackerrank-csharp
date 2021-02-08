using System;
using System.Text.RegularExpressions;

namespace PSRHackerRank
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Counting Valleys
            // Console.WriteLine("Valley Count: " + new CountOfValleys().countingValleys());

            // Jumping Clouds
            // Console.WriteLine("Jumping on Clouds: " + new JumpingClouds().jumpingOnClouds());

            // Repeated String
            // Console.WriteLine("A repeated for {0} times.", new RepeatedString().repeatedString());

            // Min-Max-Sum of array
            //new MinMaxSum().minMaxSum();

            // Sales By Match
            // Console.WriteLine("There are {0} pairs of socks.", new SalesByMatch().countPairs());

            // Birthday Cake Candles
            Console.WriteLine("There are {0} tallest candles", new BirthdayCakeCandles().birthdayCakeCandles());
        }
    }
}