/*
* There is a large pile of socks that must be paired by color. Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.

## Example
n = 7
colorRank = [1,2,1,2,1,3,2]
There is one pair of color 1 and one of color 2. 
There are three odd socks left, one of each color. The number of pairs is 2.

### Function Description

Complete the sockMerchant function in the editor below.

sockMerchant has the following parameter(s):
* int n: the number of socks in the pile
* int ar[n]: the colors of each sock

### Returns
* int: the number of pairs

#### Input Format
The first line contains an integer n, the number of socks represented in colorRank.
The second line contains n space-separated integers, ar[i], the colors of the socks in the pile.

Constraints
* 1 <= n <= 100
* 1 <= ar[i] <= 100 where 0 <= i <= n

#### Sample Input

STDIN                       Function
-----                       --------
9                           n = 9
10 20 20 10 10 30 50 10 20  ar = [10, 20, 20, 10, 10, 30, 50, 10, 20]

#### Sample Output
3
* There are three pairs of socks.
*/

using System.Collections.Generic;
using System;

namespace PSRHackerRank
{
  class SalesByMatch
  {
    private int socks;
    private int[] colors;

    public SalesByMatch()
    {
      Console.Write("Enter Socks Count: ");
      this.socks = Convert.ToInt32(Console.ReadLine().Trim());
      Console.WriteLine("Enter Socks Color in numbers:");
      this.colors = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
    }

    public int countPairs()
    {
      return countPairs(this.socks, this.colors);
    }

    private int countPairs(int pile, int[] colorRank)
    {
      int result = 0;

      // Sort the color ranks
      Array.Sort(colorRank);

      for (int i = 0; i < colorRank.Length - 1; i++)
      {
        if (colorRank[i] == colorRank[i + 1])
        {
          result++;
          // If same increase the index by 2
          i++;
        }
      }
      return result;
    }
  }
}