/*
 * There is a string, s, of lowercase English letters that is repeated infinitely many times. 
 * Given an integer, n, find and print the number of letter a's in the first n letters of the infinite string.

## Example
* s = 'abcac'
* n = 10

The substring we consider is abcacabcac, the first 10 characters of the infinite string. 
There are 4 occurrences of a in the substring.

## Function Description

Complete the repeatedString function in the editor below.

repeatedString has the following parameter(s):
s: a string to repeat
n: the number of characters to consider

### Returns
int: the frequency of a in the substring

### Input Format
The first line contains a single string, s.
The second line contains an integer, n.

### Constraints
* 1 <= |s| <= 100
* 1 <= n <= 10 pow 12
* For 25% of the test cases, n<= 10 pow 6.

## Sample Input

### Sample Input 0
aba
10

### Sample Output 0
7

#### Explanation 0
The first n=10 letters of the infinite string are abaabaabaa. Because there are 7 a's, we return 7.

### Sample Input 1
a
1000000000000

### Sample Output 1
1000000000000

#### Explanation 1
Because all of the first n=1000000000000 letters of the infinite string are a, we return 1000000000000.
 */

using System;

namespace PSRHackerRank
{
    internal class RepeatedString
    {
        private int length;
        private string str;

        public RepeatedString()
        {
            // Counting Valleys Starts here
            Console.Write("Enter No.of steps: ");
            this.length = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine();

            Console.Write("Enter string: ");
            this.str = Console.ReadLine();
            Console.WriteLine();
        }

        public long repeatedString()
        {
            return repeatedString(this.str, this.length);
        }

        // Complete the repeatedString function below.
        /// <summary>
        /// Find the repeated string number of times
        /// </summary>
        /// <param name="s"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private long repeatedString(string s, long n)
        {
            long result = 0;
            
            // Find a in current string
            char[] arr = s.ToCharArray();
            result = findCharCount(arr);
            
            // Find the number of iterations of the same string in provide length
            long noi = n / s.Length;
            result *= noi;

            // Find a in substring
            long remChars = (n % s.Length);
            if (remChars > 0)
            {
                result += findCharCount(s.Substring(0, Convert.ToInt32(remChars)).ToCharArray());
            }

            return result;
        }

        /// <summary>
        /// Find char count in a given char array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private long findCharCount(char[] arr)
        {
            long result = 0;
            foreach (char a in arr)
            {
                if (a == 'a') result++;
            }
            return result;
        }
    }
}