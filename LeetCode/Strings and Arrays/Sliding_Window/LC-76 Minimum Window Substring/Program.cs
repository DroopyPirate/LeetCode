using System;
using System.Collections.Generic;

class LC76
{
    public static string MinWindow(string s, string t)
    {
        // Return in the following case
        if (s.Length < t.Length)
            return "";

        int right = 0, left = 0;

        // Count of character and frequency for t string
        Dictionary<char, int> tMap = new Dictionary<char, int>();

        // Insert key and count for t string
        foreach (char c in t)
        {
            if (!tMap.ContainsKey(c))
                tMap[c] = 0;
            tMap[c]++;
        }

        // Count of character and frequency for window string
        Dictionary<char, int> windowMap = new Dictionary<char, int>();
        int current = 0, required = t.Length, minLength = int.MaxValue, minLeft = 0;

        // Implement sliding window
        while (right < s.Length)
        {
            // Access
            char currentChar = s[right];

            // Input in window
            if (!windowMap.ContainsKey(currentChar))
                windowMap[currentChar] = 0;
            windowMap[currentChar]++;

            // Check key and frequency, update required and current
            if (tMap.ContainsKey(currentChar) && tMap[currentChar] >= windowMap[currentChar])
            {
                current++;
            }

            // If current equals required
            while (current == required)
            {
                // Update minimum length and record minimum left
                if (right - left + 1 < minLength)
                {
                    minLength = right - left + 1;
                    minLeft = left;
                }

                // Access left character
                char leftChar = s[left];

                // Remove left character from window
                windowMap[leftChar]--;

                // If left character is target character, decrement required
                if (tMap.ContainsKey(leftChar) && windowMap[leftChar] < tMap[leftChar])
                {
                    current--;
                }

                // Loop increment
                left++;
            }

            // Loop increment
            right++;
        }

        // Return minimum result string
        return minLength == int.MaxValue ? "" : s.Substring(minLeft, minLength);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(MinWindow("ADOBECODEBANC", "ABC")); // Expected: BANC
        Console.WriteLine(MinWindow("a", "a"));               // Expected: a
        Console.WriteLine(MinWindow("a", "aa"));              // Expected: ""
        Console.WriteLine(MinWindow("a", "b"));               // Expected: ""
    }
}
