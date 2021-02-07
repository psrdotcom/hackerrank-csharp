using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSRHackerRank
{
    class MinMaxSum
    {
        int[] inputArr;

        public MinMaxSum()
        {
            Console.WriteLine("Enter array values with spaces between each number");
            this.inputArr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        public void minMaxSum()
        {
            minMaxSum(this.inputArr);
        }

        private void minMaxSum(int[] arr)
        {
            Array.Sort(arr);
            long arrSum = 0L;
            foreach (int i in arr)
            {
                arrSum += (long)i;
            }
            Console.Write("{0} {1}", (arrSum - arr[arr.Length - 1]), (arrSum - arr[0]));
        }
    }
}
