using System;
using System.Collections.Generic;
using System.Text;

namespace dsa_csharp._02_Strings
{
    public class ReverseString
    {
        // What is a Reverse String?
        // A reverse string is a string that is read in the opposite direction of its original form. For example, the reverse of "Hello World!" is "!dlroW olleH".
        public ReverseString()
        {
            //ReverseStringByManual();
            ReverseStringByLINQ();
        }

        //Time Complexity: O(n)
        // Space Complexity: O(n)
        public void ReverseStringByManual()
        {
            string str = "Hello World!";

            StringBuilder sb = new StringBuilder(str.Length);
            // String builder is mutable, so we can append characters to it without creating new string instances.
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            Console.WriteLine(sb);
        }

        //time Complexity: O(n)
        // Space Complexity: O(n)
        public void ReverseStringByLINQ()
        {
            string str = "Hello World!";

            var resp = str.Select(x => x).Reverse();

            Console.WriteLine(string.Join("", resp));
        }
    }
}
