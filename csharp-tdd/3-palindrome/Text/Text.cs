using System;
using System.Text.RegularExpressions;

namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            // Empty string is considered a palindrome
            if (string.IsNullOrEmpty(s))
                return true;

            // Remove all non-alphanumeric characters (spaces and punctuation)
            string cleaned = Regex.Replace(s, "[^a-zA-Z0-9]", "");

            // Convert to lowercase
            cleaned = cleaned.ToLower();

            // Check if the cleaned string equals its reverse
            char[] arr = cleaned.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);

            return cleaned == reversed;
        }
    }
}