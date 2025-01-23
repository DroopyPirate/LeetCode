using System;

class LC209
{
    public static int MinSubArrayLen(int target, int[] nums)
    {
        int minLength = int.MaxValue, right = 0, left = 0, sum = 0;

        while (right < nums.Length)
        {
            // Add the current element
            sum += nums[right];

            // Check if condition matches
            while (sum >= target)
            {
                minLength = Math.Min(minLength, right - left + 1);
                // Shrink the window
                sum -= nums[left++];
            }

            // Increment the loop
            right++;
        }

        return minLength == int.MaxValue ? 0 : minLength;
    }

    public static void Main(string[] args)
    {
        int[] nums = { 2, 3, 1, 2, 4, 3 };
        int target = 7;
        Console.WriteLine(MinSubArrayLen(target, nums));
    }
}
