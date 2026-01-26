using System;
using System.Collections.Generic;
using System.Text;

namespace dsa_csharp._01_Arrays.Traversal
{
    public class TraversalPatterns
    {
        public TraversalPatterns()
        {
            ForwardTraverse();
        }

        //Time Complexity : O(n)
        //Space Complexity : O(1)
        public void ForwardTraverse()
        {
            //int[] arr = [3, 7, 2, 9, 10]; Case : 1
            int[] arr = [3];  //Case : 2
            int maxElement = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                }

            }
        }

        //time Complexity : O(n)
        //space Complexity : O(1)

        public void BackwardTraverse()
        {
            int[] arr = [3, 7, 2, 9, 10];
            int sum = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                sum += arr[i];
            }
        }

        //time Complexity : O(n^2)
        //space Complexity : O(1)
        public void NestedTraversal()
        {
            int[] arr = [3, 7, 2, 9, 10];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.WriteLine(arr[i] + "," + arr[j]);
                }
            }
        }

        //Paralandm 
        //Time COmplexity : O(n)
        //Space Complexity : O(1)

        public bool TwoPointerTraversal()
        {
            int[] arr = [1, 2, 3, 2, 1];

            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                if (arr[left] != arr[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

    }
}
