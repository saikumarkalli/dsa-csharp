using System;
using System.Collections.Generic;
using System.Text;

namespace dsa_csharp.Pratice_Problems
{
    public class BasicProblems
    {
        public BasicProblems()
        {
            MaxMinSumLINQ();
            MinMaxSum();
        }
        // LINQ Style
        public void MaxMinSumLINQ()
        {
            int[] arr = [1, 2, 3, 4, 5];
                       

            long totalSum = arr.Select( x => (long)x).Sum();

            long minSum = totalSum - arr.Max(); //10

            long maxSum = totalSum - arr.Min(); //14
        }

        public void MinMaxSum()
        {
            int[] arr = [1, 2, 3, 4, 5];

            Array.Sort(arr);
            long totalSum = 0;

            for(int i = 0; i <= arr.Length -1; i++)
            {
                totalSum += arr[i];
            }

            long minSum = totalSum - arr[arr.Length - 1]; //10

            long maxSum = totalSum - arr[0]; //14

            Console.WriteLine($"{minSum}  {maxSum}");
        }
    }
}
