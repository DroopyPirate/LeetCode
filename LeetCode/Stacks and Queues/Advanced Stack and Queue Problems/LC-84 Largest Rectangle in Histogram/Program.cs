class LC84
{
    public static int LargestRectangleArea(int[] heights)
    {
        int n = heights.Length;
        int maxArea = 0;
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (stack.Count != 0 && heights[stack.Peek()] > heights[i])
            {
                int poppedElementIndex = stack.Pop();
                int rightSmallerElementIndex = i;
                int leftSmallerElementIndex = stack.Count == 0 ? -1 : stack.Peek();
                int multiplyFactor = rightSmallerElementIndex - leftSmallerElementIndex - 1;
                maxArea = Math.Max(maxArea, heights[poppedElementIndex] * multiplyFactor);
            }
            stack.Push(i);
        }

        while (stack.Count != 0)
        {
            int poppedElementIndex = stack.Pop();
            int rightSmallerElementIndex = n;
            int leftSmallerElementIndex = stack.Count == 0 ? -1 : stack.Peek();
            int multiplyFactor = rightSmallerElementIndex - leftSmallerElementIndex - 1;
            maxArea = Math.Max(maxArea, heights[poppedElementIndex] * multiplyFactor);
        }

        return maxArea;
    }

    public static void Main(string[] args)
    {
        int[] heights = { 2, 1, 5, 6, 2, 3 };
        Console.WriteLine(LargestRectangleArea(heights)); // Output: 10
    }
}
