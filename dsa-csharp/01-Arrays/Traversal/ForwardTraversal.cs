using System;
using System.Collections.Generic;
using System.Text;

namespace dsa_csharp._01_Arrays.Traversal
{
    public class ForwardTraversal
    {
        public ForwardTraversal()
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

    }
}
