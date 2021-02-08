/*
 * Sam's house has an apple tree and an orange tree that yield an abundance of fruit. Using the information given below, determine the number of apples and oranges that land on Sam's house.

In the diagram below:

The red region denotes the house, where s is the start point, and t is the endpoint. The apple tree is to the left of the house, and the orange tree is to its right.
Assume the trees are located on a single point, where the apple tree is at point a, and the orange tree is at point b.
When a fruit falls from its tree, it lands d units of distance from its tree of origin along the x-axis.
*A negative value of d means the fruit fell d units to the tree's left, and a positive value of d means it falls d units to the tree's right. *

Given the value of d for m apples and n oranges, determine how many apples and oranges will fall on Sam's house (i.e., in the inclusive range [s,t])?

For example, Sam's house is between s=7 and t-10. The apple tree is located at a=4 and the orange at b=12. There are m=3 apples and n=3 oranges.
Apples are thrown apples=[2,3,-4] units distance from a, and oranges=[3,-2,-4] units distance.
Adding each apple distance to the position of the tree, they land at [4+2, 4+3, 4+-4] = [6,7,0].
Oranges land at [12+3, 12+-2, 12+-4]=[15,10,8].
One apple and two oranges land in the inclusive range 7-10 so we print
1
2

### Function Description

Complete the countApplesAndOranges function in the editor below. It should print the number of apples and oranges that land on Sam's house, each on a separate line.

countApplesAndOranges has the following parameter(s):

s: integer, starting point of Sam's house location.
t: integer, ending location of Sam's house location.
a: integer, location of the Apple tree.
b: integer, location of the Orange tree.
apples: integer array, distances at which each apple falls from the tree.
oranges: integer array, distances at which each orange falls from the tree.

### Input Format

The first line contains two space-separated integers denoting the respective values of s and t.
The second line contains two space-separated integers denoting the respective values of a and b.
The third line contains two space-separated integers denoting the respective values of m and n.
The fourth line contains m space-separated integers denoting the respective distances that each apple falls from point a.
The fifth line contains n space-separated integers denoting the respective distances that each orange falls from point b.

### Constraints
* 1<=s,t,a,b,m,n <= 10 pow 5
* -10 pow 5 <= d <= 10 pow 5
* a < s < t < b
*
### Output Format

Print two integers on two different lines:

The first integer: the number of apples that fall on Sam's house.
The second integer: the number of oranges that fall on Sam's house.

#### Sample Input 0
7 11
5 15
3 2
-2 2 1
5 -6

#### Sample Output 0
1
1

#### Explanation 0

The first apple falls at position 5 - 2 = 3.
The second apple falls at position 5 + 2 = 7.
The third apple falls at position 5 + 1 = 6.
The first orange falls at position 15 + 5 = 20.
The second orange falls at position 15 - 6 = 9.
Only one fruit (the second apple) falls within the region between 7 and 11, so we print 1 as our first line of output.
Only the second orange falls within the region between 7 and 11, so we print 1 as our second line of output.
 */

using System;

namespace PSRHackerRank
{
    internal class AppleAndOrange
    {
        public AppleAndOrange()
        {
            Console.WriteLine("Enter House Start and End point: ");
            string[] st = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(st[0]);
            int t = Convert.ToInt32(st[1]);

            Console.WriteLine("Enter location of Apple tree and Orange tree: ");
            string[] ab = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(ab[0]);
            int b = Convert.ToInt32(ab[1]);

            Console.WriteLine("Enter number of Apple and orange count: ");
            string[] mn = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(mn[0]);
            int n = Convert.ToInt32(mn[1]);

            Console.WriteLine("Enter fallen Apples distance from tree: ");
            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));

            Console.WriteLine("Enter fallen Oranges distance from tree: ");
            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));

            // Count the apples and oranges within house range
            countApplesAndOranges(s, t, a, b, apples, oranges);
        }

        /// <summary>
        /// Count the apples and oranges within house range
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="apples"></param>
        /// <param name="oranges"></param>
        private void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int aCount = 0, oCount = 0;
            // Apples
            foreach (int i in apples)
            {
                // Apples within house range
                if (((a + i) >= s) && ((a + i) <= t))
                {
                    aCount++;
                }
            }

            // Oranges
            foreach (int i in oranges)
            {
                // Oranges within house range
                if (((b + i) >= s) && ((b + i) <= t))
                {
                    oCount++;
                }
            }

            Console.WriteLine("Apples Count {0}: ", aCount);
            Console.WriteLine("Oranges Count {0}: ", oCount);
        }
    }
}