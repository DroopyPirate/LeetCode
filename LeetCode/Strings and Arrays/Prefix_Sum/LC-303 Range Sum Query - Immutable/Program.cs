using System;

class LC303
{
    int[] sumPrefix;

    public LC303(int[] nums)
    {
        sumPrefix = nums;
        for (int i = 1; i < sumPrefix.Length; i++)
        {
            sumPrefix[i] += sumPrefix[i - 1];
        }
    }

    public int SumRange(int left, int right)
    {
        if (left == 0)
            return sumPrefix[right];
        return sumPrefix[right] - sumPrefix[left - 1];
    }

    public static void Main(string[] args)
    {
        int[] nums = { -2, 0, 3, -5, 2, -1 };

        // Initialize LC303
        LC303 obj = new LC303(nums);

        // Call SumRange for the given ranges
        Console.WriteLine(obj.SumRange(0, 2)); // Expected: 1
        Console.WriteLine(obj.SumRange(2, 5)); // Expected: -1
        Console.WriteLine(obj.SumRange(0, 5)); // Expected: -3
    }
}
