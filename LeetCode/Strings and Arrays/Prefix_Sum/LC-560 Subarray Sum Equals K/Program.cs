using System;

class LC560
{
    static int[] prefixSum;

    public static int SubarraySum(int[] nums, int k)
    {
        prefixSum = (int[])nums.Clone(); // Clone the array to avoid modifying the input array
        int result = 0;

        // Calculate prefix sums
        for (int i = 1; i < prefixSum.Length; i++)
        {
            prefixSum[i] += prefixSum[i - 1];
        }

        // Check subarray sums
        for (int i = 0; i < prefixSum.Length; i++)
        {
            for (int j = i; j < prefixSum.Length; j++)
            {
                if (GetPrefixSum(i, j) == k)
                {
                    result++;
                }
            }
        }

        return result;
    }

    public static int GetPrefixSum(int left, int right)
    {
        if (left == 0)
            return prefixSum[right];
        return prefixSum[right] - prefixSum[left - 1];
    }

    public static void Main(string[] args)
    {
        int[] nums = { 1, 1, 1 };
        int k = 2;

        Console.WriteLine(SubarraySum(nums, k)); // Expected: 2
    }
}
