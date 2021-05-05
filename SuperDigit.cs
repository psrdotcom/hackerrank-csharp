/**
Super Digit
We define super digit of an integer x using the following rules:

Given an integer, we need to find the super digit of the integer.

* If x has only digit, then its super digit is x.
* Otherwise, the super digit of x is equal to the super digit of the sum of the digits of x.

For example, the super digit of 9875 will be calculated as:

	super_digit(9875) 9+8+7+5 = 29 
	super_digit(29) 	2 + 9 = 11
	super_digit(11)		1 + 1 = 2
	super_digit(2)		= 2  

## Example

n = '9875'
k = 4

The number p is created by concatenating the string n k times so the initial p = 9875987598759875

```
    superDigit(p) = superDigit(9875987598759875)
                  9+8+7+5+9+8+7+5+9+8+7+5+9+8+7+5 = 116
    superDigit(p) = superDigit(116)
                  1+1+6 = 8
    superDigit(p) = superDigit(8)
```

All of the digits of p sum to 116. The digits of 116 sum to 18. 8 is only one digit, so it is the super digit.

## Function Description

Complete the function superDigit in the editor below. It must return the calculated super digit as an integer.

superDigit has the following parameter(s):

  *  string n: a string representation of an integer
  *  int k: the times to concatenate n to make p

## Returns

    int: the super digit of n repeated k times

## Input Format

The first line contains two space separated integers, n and k.

## Constraints

```
* 1 <= n <= 10^100000
* 1 <= k <= 10^5
```

### Sample Input 0

148 3

### Sample Output 0

3

### Explanation 0

Here n = 148 and k = 3, so p = 148148148.

```
super_digit(P) = super_digit(148148148) 
               = super_digit(1+4+8+1+4+8+1+4+8)
               = super_digit(39)
               = super_digit(3+9)
               = super_digit(12)
               = super_digit(1+2)
               = super_digit(3)
               = 3
```

### Sample Input 1

9875 4

### Sample Output 1

8

### Sample Input 2

123 3

### Sample Output 2

9

### Explanation 2

Here n = 123 and k = 3, so p = 123123123.

```
super_digit(P) = super_digit(123123123) 
               = super_digit(1+2+3+1+2+3+1+2+3)
               = super_digit(18)
               = super_digit(1+8)
               = super_digit(9)
               = 9
```
*
**/

namespace PSRHackerRank
{
    public class SuperDigit
    {
        public SuperDigit()
        {
            // Input the number and count
            Console.WriteLine("Enter Number: ");
            string n = Console.ReadLine().TrimEnd();

            Console.WriteLine("Enter string repeat count: ");
            int k = Convert.ToInt32(Console.ReadLine());

            if (n < 1 || k < 1)
            {
                Console.WriteLine("Enter valid inputs separated by space");
            }
            else
            {
                Console.WriteLine("The super digit is {0}", ComputeSuperDigit(n, k));
            }
        }

        /// <summary>
        /// Compute Super Digit
        /// </summary>
        /// <param name="n">String array of inputs</param>
        /// <param name="k">String repeats</param>
        /// <returns>int - superDigit </returns>
        public static int superDigit(string n, int k)
        {
          int sum = 0;
          string inputStr = n;
          
          do{
              sum = 0;
              Console.WriteLine("N Start: " + inputStr);
              foreach(char c in inputStr) {
                  sum += (int)Char.GetNumericValue(c);
              }
              
              inputStr = sum.ToString();
              
          } while(inputStr.Length != 1);
          
          if(k > 1) {
              inputStr = (sum * k).ToString();
              if(inputStr.Length > 1) {
                  sum = superDigit(inputStr, 0);
              } else {
                  sum = Int32.Parse(inputStr);
              }
          }
          return sum;
        }
    }
}
