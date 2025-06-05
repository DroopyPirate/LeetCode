using System;
using System.Collections.Generic;

class LC503
{
    public static int[] nextGreaterElements(int[] nums)
    {
        Stack<int> stack = new Stack<int>();
        int capacity = nums.Length;
        int[] answer = new int[capacity];

        for (int i = 0; i < capacity; i++)
        {
            answer[i] = -1;
        }

        for (int i = 0; i < capacity * 2; i++)
        {
            while (stack.Count != 0 && nums[stack.Peek()] < nums[i % capacity])
            {
                answer[stack.Pop()] = nums[i % capacity];
            }

            if (i < capacity)
                stack.Push(i);
        }

        return answer;
    }

    public static void Main(string[] args)
    {
        int[] nums = { 1, 2, 1 };
        int[] result = nextGreaterElements(nums);

        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
}
