class LC239
{
    public static int[] maxSlidingWindow(int[] nums, int k)
    {
        List<int> result = new List<int>();
        LinkedList<int> deque = new LinkedList<int>();

        for (int index = 0; index < nums.Length; index++)
        {
            int num = nums[index];

            while (deque.Count > 0 && deque.Last.Value < num)
            {
                deque.RemoveLast();
            }

            deque.AddLast(num);

            if (index >= k && nums[index - k] == deque.First.Value)
            {
                deque.RemoveFirst();
            }

            if (index >= k - 1)
            {
                result.Add(deque.First.Value);
            }
        }

        return result.ToArray();
    }

    public static void Main(string[] args)
    {
        int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;
        int[] result = maxSlidingWindow(nums, k);
        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
}
