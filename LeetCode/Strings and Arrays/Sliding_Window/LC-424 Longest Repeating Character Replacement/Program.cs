using System;
using System.Collections.Generic;
using System.Linq;

public class LC424
{
    public int CharacterReplacement(string s, int k)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        int right = 0, left = 0, result = 0;

        while (right < s.Length)
        {
            // Access the current character
            char currentChar = s[right];

            // Update the dictionary and record frequency
            if (!map.ContainsKey(currentChar))
                map[currentChar] = 0;
            map[currentChar]++;

            // Get max frequency
            int maxValue = map.Values.Max();

            // Calculate condition value
            int condition = (right - left + 1) - maxValue;

            // Match the condition
            if (condition == k)
            {
                result = Math.Max(result, right - left + 1);
            }

            // If condition exceeds k, shrink the window
            if (condition > k)
            {
                char leftChar = s[left];
                map[leftChar]--;
                if (map[leftChar] == 0)
                {
                    map.Remove(leftChar);
                }
                left++;
            }

            // Increment the loop
            right++;
        }

        // Return the result
        return result == 0 ? s.Length : result;
    }

    public static void Main(string[] args)
    {
        LC424 obj = new LC424();
        Console.WriteLine(obj.CharacterReplacement("ABAB", 2)); // Expected: 4
        Console.WriteLine(obj.CharacterReplacement("AABABBA", 1)); // Expected: 4
    }
}
