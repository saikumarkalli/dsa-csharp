namespace dsa_csharp._02_Strings
{
    public class BasicStringProblems
    {
        // Find the number of vowels in a given string.
        public BasicStringProblems()
        {
            FindVowelsCount();
        }

        // Time Complexity: O(n)
        // Space Complexity: O(1)
        public void FindVowelsCount()
        {
            string str = "astronomer".ToLower();
            string[] vowels = ["a", "e", "i", "o", "u"];
            int count = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (vowels.Contains(str[i].ToString()))
                {
                    count++;
                }
            }


        }

        // Time Complexity: O(n)
        // Space Complexity: O(n)
        public void FindVowelsCountByLINQ()
        {
            string str = "astronomer".ToLower();
            string[] vowels = ["a", "e", "i", "o", "u"];
            int count = str.Count(x => vowels.Contains(x.ToString()));
        }
    }
}
