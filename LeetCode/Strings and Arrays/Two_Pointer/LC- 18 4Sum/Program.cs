using System;
using System.Collections.Generic;

class LC18
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        // Sort the array
        Array.Sort(nums);

        var list = new List<IList<int>>();

        // Loop for fixing one element
        for (int i = 0; i < nums.Length - 3; i++)
        {
            // Skip duplicates
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            // Loop for fixing second element
            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                // Skip duplicates
                if (j > i + 1 && nums[j] == nums[j - 1]) continue;

                // Take remaining subarray for two-pointer approach
                int left = j + 1, right = nums.Length - 1;

                // Two-pointer approach
                while (left < right)
                {
                    long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];
                    if (sum == target)
                    {
                        list.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });

                        // Skip duplicates
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;

                        left++;
                        right--;
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
        }

        return list;
    }

    public static void Main(string[] args)
    {
        LC18 lc18 = new LC18();
        int[] nums = { 1, 0, -1, 0, -2, 2 };
        int target = 0;
        IList<IList<int>> list = lc18.FourSum(nums, target);
        foreach (var l in list)
        {
            Console.WriteLine(string.Join(", ", l));
        }
    }
}
