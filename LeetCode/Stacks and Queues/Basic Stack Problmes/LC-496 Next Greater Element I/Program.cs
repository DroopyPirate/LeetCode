using System;
using System.Collections.Generic;

class LC496
{
    public static int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> table = new Dictionary<int, int>();
        Stack<int> stack = new Stack<int>();

        foreach (int num in nums2)
        {
            while (stack.Count > 0 && stack.Peek() < num)
            {
                table[stack.Pop()] = num;
            }
            stack.Push(num);
        }

        while (stack.Count > 0)
        {
            table[stack.Pop()] = -1;
        }

        for (int i = 0; i < nums1.Length; i++)
        {
            nums1[i] = table[nums1[i]];
        }

        return nums1;
    }

    public static void Main()
    {
        int[] nums1 = { 4, 1, 2 };
        int[] nums2 = { 1, 3, 4, 2 };
        int[] result = NextGreaterElement(nums1, nums2);

        Console.WriteLine(string.Join(" ", result));
    }
}
