/* @Copyright of the problem HackerRank
 * @Copyright of the solution @author: Suresh Raju Pilli
 * Counting Valleys
 * 
 * An avid hiker keeps meticulous records of their hikes. 
 * During the last hike that took exactly 'steps' steps, for every step it was noted if 
 * it was an uphill, U , or a downhill, D step. Hikes always start and end at sea level, 
 * and each step up or down represents a 1 unit change in altitude. 
 * We define the following terms:

A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.
Given the sequence of up and down steps during a hike, find and print the number of valleys walked through.

##Example

steps = 8 path = [DDUUUUDD]

The hiker first enters a valley 2 units deep. Then they climb out and up onto a mountain 2 units high. 
Finally, the hiker returns to sea level and ends the hike.

### Function Description

Complete the countingValleys function in the editor below.

countingValleys has the following parameter(s):

- int steps: the number of steps on the hike
- string path: a string describing the path

#### Returns
- int: the number of valleys traversed

### Input Format
The first line contains an integer 'steps', the number of steps in the hike.
The second line contains a single string 'path', of 'steps' characters that describe the path.

### Constraints
* 2<=steps<=10pow6
* path[i] E {UD}

### Sample Input
8
UDDDUDUU

### Sample Output
1

## Explanation

If we represent _ as sea level, a step up as /, and a step down as \, the hike can be drawn as:

_/\      _
   \    /
    \/\/
The hiker enters and leaves one valley.
 *
 * */

using System;
using System.Text.RegularExpressions;

namespace CSharp
{
    public class CountOfValleys
    {
        private int steps;
        private string path;

        public CountOfValleys()
        {
            // Counting Valleys Starts here
            Console.Write("Enter No.of steps: ");
            this.steps = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine();

            Console.Write("Enter Steps (U-Up and D-Down): ");
            this.path = Console.ReadLine();
            Console.WriteLine();
        }

        /*
         * Complete the 'countingValleys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER steps
         *  2. STRING path
         */

        // Counting Valleys
        public int countingValleys()
        {
            return countingValleys(this.steps, this.path);
        }

        /// <summary>
        /// Counting Valleys
        /// </summary>
        /// <param name="steps"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        private int countingValleys(int steps, string path)
        {
            if (steps <= 0 || path.Length <= 0)
            {
                return 0;
            }

            Console.WriteLine("Steps: " + steps + ", Path: " + path);

            if (!Regex.Match(path.ToLower(), "^[ud]*$").Success)
            {
                return 0;
            }

            char[] splittedPath = path.ToLower().ToCharArray();

            int uCount = 0, dCount = 0, vCount = 0, hCount = 0;
            bool hill = false, valley = false;
            for (int i = 0; i < splittedPath.Length; i++)
            {
                // U match
                if (splittedPath[i] == 'u')
                {
                    if (dCount < 0)
                    {
                        dCount++;
                    }
                    else
                    {
                        uCount++;
                        hill = true;
                    }
                }
                else if (splittedPath[i] == 'd')
                { // D match
                    if (uCount > 0)
                    {
                        uCount--;
                    }
                    else
                    {
                        dCount--;
                        valley = true;
                    }
                }

                // Count Valleys
                if (uCount == 0 && dCount == 0)
                {
                    if (hill)
                    {
                        // No.of hills
                        hCount++;
                    }
                    else
                    {
                        // No.of valleys
                        vCount++;
                    }

                    // Reset booleans
                    hill = false;
                    valley = false;
                }
            }
            return vCount;
        }
    }
}