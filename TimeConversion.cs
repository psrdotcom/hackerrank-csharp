/*
 * Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.

Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

## Example
* s = '12:01:00PM'
Return '12:01:00'.

* s = '12:01:00AM'
Return '00:01:00'.

## Function Description

Complete the timeConversion function in the editor below. It should return a new string representing the input time in 24 hour format.

timeConversion has the following parameter(s):
* string s: a time in 12 hour format

### Returns
* string: the time in 24 hour format

### Input Format

A single string s that represents a time in 12-hour clock format (i.e.:hh:mm:ssAM or hh:mm:ssPM).

### Constraints

* All input times are valid

#### Sample Input 0
07:05:45PM

#### Sample Output 0
19:05:45
 */

using System;

namespace PSRHackerRank
{
    internal class TimeConversion
    {
        private bool parseVal;

        public TimeConversion()
        {
            string timein12hours;
            Console.WriteLine("Enter time in 12 hour format (hh:mm:ssAM or hh:mm:ssPM): ");
            timein12hours = Console.ReadLine();
            string result = timeConversion(timein12hours);
            if (!parseVal)
            {
                Console.WriteLine("Enter valid date in 12 hour format (hh:mm:ssAM or hh:mm:ssPM)");
            }
            else
            {
                Console.WriteLine("Time in 24 hour format is : {0}", result);
            }
        }

        /// <summary>
        /// Time Conversion from 12 hour to 24 hour format
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private string timeConversion(string s)
        {
            DateTime dt;
            parseVal = DateTime.TryParse(s, out dt);
            return dt.ToString("HH:mm:ss");
        }
    }
}