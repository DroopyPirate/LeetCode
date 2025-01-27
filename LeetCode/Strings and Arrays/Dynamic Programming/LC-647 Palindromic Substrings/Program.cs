class Solution
{
    public static int CountSubstrings(string s)
    {
        int length = s.Length;
        int count = length;
        bool[,] dp = new bool[length, length];

        // Create dynamic programming table
        dp[0, 0] = true;
        for (int i = 1; i < length; i++)
        {
            dp[i, i] = true;
            if (s[i] == s[i - 1])
            {
                dp[i - 1, i] = true;
                count++;
            }
        }

        for (int diff = 2; diff < length; diff++)
        {
            for (int i = 0; i < length - diff; i++)
            {
                int j = i + diff;
                if (s[i] == s[j] && dp[i + 1, j - 1])
                {
                    count++;
                    dp[i, j] = true;
                }
            }
        }

        return count;
    }

    static void Main()
    {
        // Test cases
        Console.WriteLine(Solution.CountSubstrings("abc")); // Output: 3
        Console.WriteLine(Solution.CountSubstrings("aaa")); // Output: 6
    }
}
