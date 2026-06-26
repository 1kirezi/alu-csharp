using System;

namespace Text
{
    /// <summary>
    /// Provides string operations.
    /// </summary>
    public class Str
    {
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s))
                return -1;

            // Since input is lowercase letters, we can use an array of size 26.
            int[] count = new int[26];

            // First pass: count occurrences
            foreach (char c in s)
            {
                count[c - 'a']++;
            }

            // Second pass: find first character with count == 1
            for (int i = 0; i < s.Length; i++)
            {
                if (count[s[i] - 'a'] == 1)
                    return i;
            }

            return -1;
        }
    }
}