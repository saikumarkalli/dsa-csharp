using System;
using System.Collections.Generic;
using System.Text;

namespace dsa_csharp._02_Strings
{
    public class Palindrome
    {
        // What is a Palindrome? 
        // A palindrome is a word, phrase, number, or other sequence of characters that reads the same forward and backward (ignoring spaces, punctuation, and capitalization).
        public Palindrome()
        {
            IsPalindrome();
        }

        //Time Complexity: O(n)
        // Space Complexity: O(1)
        public void IsPalindrome()
        {
            string str = "madam";

            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (!(str[left] == str[right]))
                {
                    Console.WriteLine("Not a palindrome");
                    return;
                }

                left++;
                right--;
            }
        }

        //Time Complexity: O(n)
        // Space Complexity: O(n)
        public void IsPalindromeByLINQ()
        {
            string str = "madam";
            var reversed = new string(str.Reverse().ToArray());
            if (str.Equals(reversed, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
        }


    }
}
