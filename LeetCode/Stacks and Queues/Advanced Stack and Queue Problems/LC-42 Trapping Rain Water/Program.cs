class LC42
{
    public static int Trap(int[] height)
    {
        int length = height.Length;
        int area = 0;
        Stack<int> stack = new Stack<int>();

        for (int currentIndex = 0; currentIndex < length; currentIndex++)
        {
            while (stack.Count != 0 && height[stack.Peek()] < height[currentIndex])
            {
                int middleElementIndex = stack.Pop();

                if (stack.Count == 0)
                    break;

                int leftElementIndex = stack.Peek();
                int uncalculatedHeight = Math.Min(height[currentIndex] - height[middleElementIndex],
                                                  height[leftElementIndex] - height[middleElementIndex]);
                int spaceBetweenLeftAndCurrent = currentIndex - leftElementIndex - 1;

                area += spaceBetweenLeftAndCurrent * uncalculatedHeight;
            }
            stack.Push(currentIndex);
        }

        return area;
    }

    public static void Main(string[] args)
    {
        int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
        Console.WriteLine("Trapped rainwater: " + Trap(height)); // Output: 6
    }
}


/*

01021013212 1
01234567891011

e = 1 pop = 0 total = 0
e = 2 pop = 0 total = 1
e = 1 pop = 0 total = 2
e = 3 pop = 1 total = 2
e = 3 pop = 1 total = 5
e = 2 pop = 1 total = 6



                        1   1
          0   1       2 2 2 2
        1 1 1 1 1   3 3 3 3 3
  0   2 2 2 2 2 2 2 2 2 2 2 2
0 1 1 1 1 1 1 1 1 1 1 1 1 1 1 

*/
// Output: 6