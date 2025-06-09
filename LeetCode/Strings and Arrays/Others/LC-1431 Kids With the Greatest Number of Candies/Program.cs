class LC1431
{
    public static List<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        List<bool> result = new List<bool>();
        int max = 0;
        foreach (int candy in candies)
        {
            if (candy >= max)
            {
                max = candy;
            }
        }
        foreach (int candy in candies)
        {
            result.Add(candy + extraCandies >= max);
        }
        return result;
    }

    public static void Main(string[] args)
    {
        int[] candies = { 2, 3, 5, 1, 3 };
        int extraCandies = 3;
        List<bool> result = KidsWithCandies(candies, extraCandies);
        Console.WriteLine($"[{string.Join(", ", result).ToLower()}]"); // Output: [true, true, true, false, true]
    }
}
