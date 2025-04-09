using System;

public class LC198
{
    public static int Rob(int[] nums)
    {
        int n = nums.Length;
        if (n == 1) return nums[0];

        int max = nums[0];

        for (int i = 2; i < n; i++)
        {
            nums[i] += max;
            max = Math.Max(nums[i - 1], nums[i - 2]);
        }

        return Math.Max(nums[n - 1], nums[n - 2]);
    }

    public static void Main(string[] args)
    {
        int[] nums = { 2, 7, 9, 3, 1 };
        Console.WriteLine(Rob(nums)); // Output: 12
    }
}
