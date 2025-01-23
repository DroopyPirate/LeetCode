using System;
using System.Collections.Generic;

class LC15
{
    public static List<List<int>> ThreeSum(int[] nums)
    {
        // Sort the array
        Array.Sort(nums);

        List<List<int>> list = new List<List<int>>();

        // Iterate the array
        for (int i = 0; i < nums.Length - 2; i++)
        {
            // Take the remaining right side of the array
            int left = i + 1, right = nums.Length - 1;

            // Skip duplicate values
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                if (sum == 0)
                {
                    list.Add(new List<int> { nums[i], nums[left], nums[right] });
                    // Skip duplicate values
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;
                    left++;
                    right--;
                }
                else if (sum > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }

        return list;
    }

    public static void Main(string[] args)
    {
        int[] nums = { -1, 0, 1, 2, -1, -4 };
        List<List<int>> list = ThreeSum(nums);
        foreach (var l in list)
        {
            Console.WriteLine($"[{string.Join(", ", l)}]");
        }
    }
}
