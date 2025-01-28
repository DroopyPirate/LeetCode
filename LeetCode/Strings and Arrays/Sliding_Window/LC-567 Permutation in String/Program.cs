class LC567
{
    public static bool CheckInclusion(string s1, string s2)
    {
        Dictionary<char, int> s1Map = new Dictionary<char, int>();
        Dictionary<char, int> s2Map = new Dictionary<char, int>();
        int right = 0, left = 0, targetCount = 0, s1Length = s1.Length, s2Length = s2.Length;

        // Initialize s1Map with frequency of characters in s1
        for (int i = 0; i < s1Length; i++)
        {
            char currentChar = s1[i];
            s1Map[currentChar] = s1Map.GetValueOrDefault(currentChar, 0) + 1;
        }

        // Sliding window approach
        while (right < s2Length)
        {
            // Get current character
            char currentChar = s2[right];

            // Update s2 HashMap
            s2Map[currentChar] = s2Map.GetValueOrDefault(currentChar, 0) + 1;

            if (s1Map.ContainsKey(currentChar) && s1Map[currentChar] >= s2Map[currentChar])
            {
                targetCount++;
            }

            // Shrink window when window length is equal to s1Length
            if (right - left + 1 == s1Length)
            {
                // Check if target and length are matched
                if (targetCount == s1Length)
                    return true;

                // Before shrinking, update s2 HashMap
                char leftChar = s2[left];
                s2Map[leftChar] = s2Map.GetValueOrDefault(leftChar, 0) - 1;

                // Also decrement targetCount if leftChar was in s1 and its frequency is less than s1
                if (s1Map.ContainsKey(leftChar) && s2Map[leftChar] < s1Map[leftChar])
                    targetCount--;

                left++;
            }

            // Expand the window
            right++;
        }

        return false;
    }

    public static void Main()
    {
        Console.WriteLine(CheckInclusion("ab", "eidbaooo"));
        Console.WriteLine(CheckInclusion("ad   ", "eidbaooo"));
    }
}
