using System;
using System.Collections.Generic;

class LC3
{
    public static int LengthOfLongestSubstring(string s)
    {
        int left = 0, right = 0, maxLength = 0;
        HashSet<char> set = new HashSet<char>();

        while (right < s.Length)
        {
            char currentChar = s[right];

            while (set.Contains(currentChar))
            {
                set.Remove(s[left]);
                left++;
            }

            set.Add(currentChar);
            maxLength = Math.Max(maxLength, right - left + 1);
            right++;
        }

        return maxLength;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(LengthOfLongestSubstring("abcabcbb")); // Expected: 3
        Console.WriteLine(LengthOfLongestSubstring("bbbbb"));    // Expected: 1
        Console.WriteLine(LengthOfLongestSubstring("pwwkew"));   // Expected: 3
        Console.WriteLine(LengthOfLongestSubstring(""));         // Expected: 0
        Console.WriteLine(LengthOfLongestSubstring(" "));        // Expected: 1
        Console.WriteLine(LengthOfLongestSubstring("au"));       // Expected: 2
    }
}
