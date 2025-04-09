using System;

public class LC53
{
    public static int MaxSubArray(int[] nums)
    {
        int n = nums.Length;
        int[] dp = new int[n];
        int max = nums[0];
        dp[0] = nums[0];

        for (int i = 1; i < n; i++)
        {
            dp[i] = Math.Max(dp[i - 1] + nums[i], nums[i]);
            if (dp[i] > max)
                max = dp[i];
        }

        return max;
    }

    public static void Main(string[] args)
    {
        int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        Console.WriteLine(MaxSubArray(nums)); // Output: 6
    }
}
