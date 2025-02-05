using System;

public class LC287
{
    // Floyd's Tortoise and Hare algorithm
    public static int FindDuplicateByFloydTortoiseAndHare(int[] nums)
    {
        int slow = nums[0], fast = nums[0];

        while (true)
        {
            slow = nums[slow];
            fast = nums[nums[fast]];
            if (slow == fast)
                break;
        }

        int slow2 = nums[0];

        while (slow != slow2)
        {
            slow = nums[slow];
            slow2 = nums[slow2];
        }
        return slow;
    }

    // Brute force by boolean array
    public static int FindDuplicateByBooleanBruteForce(int[] nums)
    {
        int n = nums.Length;
        bool[] check = new bool[n + 1];
        foreach (int i in nums)
        {
            if (check[i]) return i;
            else check[i] = true;
        }
        return -1;
    }

    public static void Main()
    {
        int[] nums = { 1, 3, 4, 2, 2 };
        Console.WriteLine(FindDuplicateByFloydTortoiseAndHare(nums));
        Console.WriteLine(FindDuplicateByBooleanBruteForce(nums));
    }
}
