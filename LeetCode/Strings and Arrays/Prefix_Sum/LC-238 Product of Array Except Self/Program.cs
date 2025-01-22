using System;

class LC238
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] prefixProduct = new int[nums.Length];
        
        // Initialize the array with 1s
        for (int i = 0; i < nums.Length; i++)
        {
            prefixProduct[i] = 1;
        }

        int rightTemp = 1;
        // Calculate prefix products from the left
        for (int i = 0; i < nums.Length; i++)
        {
            prefixProduct[i] *= rightTemp;
            rightTemp *= nums[i];
        }

        int leftTemp = 1;
        // Calculate prefix products from the right
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            prefixProduct[i] *= leftTemp;
            leftTemp *= nums[i];
        }

        return prefixProduct;
    }

    public static void Main(string[] args)
    {
        LC238 lc238 = new LC238();
        int[] nums = { 1, 2, 3, 4 };
        int[] result = lc238.ProductExceptSelf(nums);

        // Print the result
        foreach (int val in result)
        {
            Console.Write(val + " "); // Expected: 24 12 8 6
        }
    }
}
