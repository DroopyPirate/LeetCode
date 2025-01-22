using System;
using System.Collections.Generic;

public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        List<int> result = new List<int>();
        Dictionary<char, int> pMap = new Dictionary<char, int>();
        Dictionary<char, int> sMap = new Dictionary<char, int>();
        int right = 0, left = 0, current = 0, required = p.Length;

        // Create HashMap for string `p` and record frequency
        foreach (char c in p)
        {
            if (!pMap.ContainsKey(c))
                pMap[c] = 0;
            pMap[c]++;
        }

        // Iterate through string `s`
        while (right < s.Length)
        {
            // Access current character
            char currentChar = s[right];

            // Add to map
            if (!sMap.ContainsKey(currentChar))
                sMap[currentChar] = 0;
            sMap[currentChar]++;

            // Check frequency and update current count
            if (pMap.ContainsKey(currentChar) && sMap[currentChar] <= pMap[currentChar])
            {
                current++;
            }

            // Check window size
            if (right - left + 1 == required)
            {
                // Condition matched
                if (current == required)
                {
                    result.Add(left);
                }

                // Access left character
                char leftChar = s[left];

                // Update current count
                if (pMap.ContainsKey(leftChar) && sMap[leftChar] <= pMap[leftChar])
                {
                    current--;
                }

                // Shrink window from left and update frequency
                sMap[leftChar]--;
                left++;
            }

            // Expand the window
            right++;
        }

        return result;
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var result1 = solution.FindAnagrams("cbaebabacd", "abc"); // Expected: [0, 6]
        var result2 = solution.FindAnagrams("abab", "ab");        // Expected: [0, 1, 2]

        Console.WriteLine(string.Join(", ", result1));
        Console.WriteLine(string.Join(", ", result2));
    }
}
