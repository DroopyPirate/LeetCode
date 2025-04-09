using System;

public class LC70
{
    public static int ClimbStairs(int n)
    {
        // 1 - 1
        // 2 - 2 [2, 1-2]
        // 3 - 3 [1-3, 2-3]
        // 4 - 5 [1-2-3-4, 1-3-4, 1-2-4, 2-3-4, 2-4]
        // 5 - 8 [1-2-3-4-5, 1-3-4-5, 1-3-5, 1-2-4-5, 1-2-3-5, 2-3-4-5, 2-4-5, 2-3-5]
        // This series follows the Fibonacci sequence until n=3 where the answer is 3.

        if(n <= 3)
            return n;

        int current = 3, previous = 2;

        for (int i = 4; i <= n; i++)
        {
            int temp = current;
            current += previous;
            previous = temp;
        }

        return current;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(ClimbStairs(5)); // Output: 8
        Console.WriteLine(ClimbStairs(6)); // Output: 13
        Console.WriteLine(ClimbStairs(7)); // Output: 21
    }
    // Time complexity: O(n)
}
