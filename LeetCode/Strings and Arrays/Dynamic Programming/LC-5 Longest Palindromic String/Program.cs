class LC5
{
    public static string LongestPalindrome(string s)
    {
        int length = s.Length;
        bool[,] dp = new bool[length, length];
        int[] ans = new int[] { 0, 0 };

        for (int i = 0; i < length - 1; i++)
        {
            dp[i, i] = true;
            if (s[i] == s[i + 1])
            {
                dp[i, i + 1] = true;
                ans[0] = i;
                ans[1] = i + 1;
            }
        }
        dp[length - 1, length - 1] = true;

        for (int diff = 2; diff < length; diff++)
        {
            for (int i = 0; i < length - diff; i++)
            {
                int j = i + diff;
                if (s[i] == s[j] && dp[i + 1, j - 1])
                {
                    dp[i, j] = true;
                    ans[0] = i;
                    ans[1] = j;
                }
            }
        }

        return s.Substring(ans[0], ans[1] - ans[0] + 1);
    }

    public static void Main(string[] args)
    {
        string s = "babad";
        Console.WriteLine(LongestPalindrome(s));
    }
}
