using System;

public class LC746
{
    public static int MinCostClimbingStairs(int[] cost)
    {
        int n = cost.Length;
        int[] dp = new int[n];
        for (int i = 0; i < n; i++)
        {
            if (i < 2)
                dp[i] = cost[i];
            else
                dp[i] = cost[i] + Math.Min(dp[i - 1], dp[i - 2]);
        }
        return Math.Min(dp[n - 1], dp[n - 2]);
    }

    public static void Main(string[] args)
    {
        int[] cost = { 10, 15, 20 };
        Console.WriteLine(MinCostClimbingStairs(cost)); // Output: 15
    }
}
