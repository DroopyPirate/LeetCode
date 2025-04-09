using System;

public class LC509
{
    public static int Fib(int n)
    {
        // if (n == 0) return 0;
        // if (n==1) return 1;
        // return Fib(n-1) + Fib(n-2);

        //Or by dynamic programming
        // Time complexity: O(n)
        // Space complexity: O(n)


        // Base cases
        if (n == 0 || n == 1)
            return n;

        int[] dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }

        return dp[n];
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Fib(4)); // Output: 3
        Console.WriteLine(Fib(5)); // Output: 5
        Console.WriteLine(Fib(6)); // Output: 8
        Console.WriteLine(Fib(7)); // Output: 13
    }
}
