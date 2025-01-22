using System;

class LC974
{
    public static int SubarraysDivByK(int[] nums, int k)
    {
        int[] prefixSum = new int[nums.Length];
        prefixSum[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            prefixSum[i] = prefixSum[i - 1] + nums[i];
        }

        int subArrayCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i; j < nums.Length; j++)
            {
                if (SubArraySum(prefixSum, i, j) % k == 0)
                {
                    // Console.WriteLine($"i: {i}, j: {j}");
                    subArrayCount++;
                }
            }
        }

        return subArrayCount;
    }

    public static int SubArraySum(int[] prefixSum, int start, int end)
    {
        if (start == 0)
            return prefixSum[end];
        else
            return prefixSum[end] - prefixSum[start - 1];
    }

    public static void Main(string[] args)
    {
        int[] nums = { 4, 5, 0, -2, -3, 1 };
        int k = 5;
        Console.WriteLine(SubarraysDivByK(nums, k));
    }
}
