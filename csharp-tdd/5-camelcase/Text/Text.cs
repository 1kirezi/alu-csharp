using System;

namespace Text
{
    public class Str
    {
        public static int CamelCase(string s)
{
    if (string.IsNullOrEmpty(s))
        return 0;

    int wordCount = 1;  // first word always exists
    for (int i = 1; i < s.Length; i++)  // start from index 1, not 0
    {
        if (char.IsUpper(s[i]))
            wordCount++;
    }
    return wordCount;
}
        }
}
