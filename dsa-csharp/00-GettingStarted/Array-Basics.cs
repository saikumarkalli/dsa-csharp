using System;
using System.Collections.Generic;
using System.Text;

namespace dsa_csharp._00_GettingStarted
{
    public class Array_Basics
    {
        public Array_Basics()
        {
            //reverseArray();
            //findMaxMinInArray();
            //countOfEvenOdds();
            //sumOfElements();
        }

        public static void reverseArray()
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> r = new List<int>(arr.Count);
            for (int i = arr.Count(); i > 0; i--) //iterate based on the lenght of 'n'
            {
                r.Add(arr[i - 1]);
            }

            Console.WriteLine("Reversed Array Value :", String.Join(" ", r));

            //Time Complexity : O(n)
            //Space Complexity : O(n)
        }

        public static void findMaxMinInArray()
        {
            int[] arr = { 3, 5, 7, 2, 8, -2 };
            int max = arr[0];
            int min = arr[0];

            for (int i = 0; i< arr.Length; i++)
            {
                int value = arr[i];

                //validate the array element for MAX
                if(value > max)
                {
                    max = value;
                }

                //validate the array element for MIN
                if(value < min)
                {
                    min = value;
                }
            }

            Console.WriteLine("Max Value : " + max);
            Console.WriteLine("Min Value : " + min);

            //Time Complexity : O(n)
            //Space Complexity : O(1)

        }

        public static void countOfEvenOdds()
        {
            //even or odd numbers
            //int[] arr = { 2, 3, 4, 5, -2 };
            int[] arr = { -3};
            int evenCount = 0;
            int oddsCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddsCount++;
                }
            }

            Console.WriteLine("Even Count : "+ evenCount);
            Console.WriteLine("Odd Count : "+ oddsCount);

            //Time Complexity : O(n)
            //Space Complexity : O(1)
        }

        public static void sumOfElements()
        {
            int[] arr = { 1, 2, 3, 4 };
            int sum = 0;

            for(int i = 0; i< arr.Length;i++)
            {
                sum += arr[i];
            }

            Console.WriteLine("Sum of Elements: " + sum);

            //Time : O(n)
            //Space: O(1)
        }
    }
}
