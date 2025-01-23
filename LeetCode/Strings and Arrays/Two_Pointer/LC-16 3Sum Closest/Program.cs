using System;
using System.Linq;

class LC16
{
    public static int ThreeSumClosest(int[] nums, int target)
    {
        // Sort the array
        Array.Sort(nums);
        int result = 0, difference = int.MaxValue;

        // Iterate the array
        for (int i = 0; i < nums.Length - 2; i++)
        {
            // Take the remaining right side of array
            int left = i + 1, right = nums.Length - 1;

            // Skip duplicate values
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            while (left < right)
            {
                int sum = nums[i] + nums[right] + nums[left];
                int tempDifference = target - sum;
                tempDifference = tempDifference < 0 ? -tempDifference : tempDifference;

                if (tempDifference < difference)
                {
                    result = sum;
                    difference = tempDifference;
                }
                else if (sum > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }

        return result;
    }

    public static void Main(string[] args)
    {
        int[] nums = { -1, 2, 1, -4 };
        int target = 1;
        Console.WriteLine(ThreeSumClosest(nums, target));
    }
}
