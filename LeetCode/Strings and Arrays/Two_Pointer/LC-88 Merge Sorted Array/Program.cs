using System;

class LC88
{
    public static void merge(int[] nums1, int m, int[] nums2, int n)
    {
        int mergedLength = m + n - 1, nums1Length = m - 1, nums2Length = n - 1;
        while (nums1Length >= 0 && nums2Length >= 0)
        {
            if (nums1[nums1Length] >= nums2[nums2Length])
            {
                nums1[mergedLength--] = nums1[nums1Length--];
            }
            else
            {
                nums1[mergedLength--] = nums2[nums2Length--];
            }
        }
        while (nums1Length >= 0)
        {
            nums1[mergedLength--] = nums1[nums1Length--];
        }
        while (nums2Length >= 0)
        {
            nums1[mergedLength--] = nums2[nums2Length--];
        }
    }

    public static void Main(string[] args)
    {
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = { 2, 5, 6 };
        merge(nums1, 3, nums2, 3);
        foreach (int num in nums1)
        {
            Console.Write(num + " ");
        }
    }
}
