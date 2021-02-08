/*
 * You are in charge of the cake for a child's birthday. You have decided the cake will have one candle for each year of their total age. They will only be able to blow out the tallest of the candles. Count how many candles are tallest.

## Example
candles = [4,4,1,3]

The maximum height candles are 4 units high. There are 2 of them, so return 2.

### Function Description

Complete the function birthdayCakeCandles in the editor below.

birthdayCakeCandles has the following parameter(s):
* int candles[n]: the candle heights

### Returns
* int: the number of candles that are tallest

### Input Format
The first line contains a single integer, n, the size of candles[].
The second line contains n space-separated integers, where each integer i describes the height of candles[i].

### Constraints
* 1 <= n <=10 pow 5
* 1 <= candles[i] <= 10 pow 7
* 
#### Sample Input 0
4
3 2 1 3

#### Sample Output 0
2

#### Explanation 0
Candle heights are [3,2,1,3]. The tallest candles are 3 units, and there are 2 of them.

#### Sample Input 1
10
18 90 90 13 90 75 90 8 90 43

#### Sample Output 1
5

#### Explanation 0
Candle heights are [18 90 90 13 90 75 90 8 90 43]. The tallest candles are 90 units, and there are 5 of them.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSRHackerRank
{
    class BirthdayCakeCandles
    {
        private int n;
        private int[] c;

        public BirthdayCakeCandles()
        {
            // Counting Valleys Starts here
            Console.Write("Enter No.of candles: ");
            this.n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter candles heights seperated by space: ");
            this.c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            Console.WriteLine();
        }

        public int birthdayCakeCandles()
        {
            return birthdayCakeCandles(this.c);
        }

        private int birthdayCakeCandles(int[] candles)
        {
            int result = 0;
            // Get max val of array
            int maxVal = candles.Max();

            foreach(int i in candles)
            {
                if(i == maxVal)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
