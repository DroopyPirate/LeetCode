using System;
using System.Collections.Generic;

class LC1
{
    public static int[] TwoSum(int[] nums, int target)
    {
        // Create a dictionary to store numbers and their indices
        Dictionary<int, int> map = new Dictionary<int, int>();

        // Iterate through the array
        for (int i = 0; i < nums.Length; i++)
        {
            // Calculate the complement
            int find = target - nums[i];

            // Check if the complement exists in the dictionary
            if (map.ContainsKey(find))
            {
                // Return the indices of the complement and current number
                return new int[] { map[find], i };
            }

            // Add the current number and its index to the dictionary
            map[nums[i]] = i;
        }

        // Return an empty array if no solution is found
        return new int[] { };
    }

    public static void Main(string[] args)
    {
        // Define the input array and target
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        // Call TwoSum
        int[] result = TwoSum(nums, target);

        // Print the result
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
}
