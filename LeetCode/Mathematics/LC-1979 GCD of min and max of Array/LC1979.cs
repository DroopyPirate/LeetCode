using System;

class LC1979
{
    public static int FindGCD(int[] nums)
    {
        int min = int.MaxValue;
        int max = 0;

        // Find the minimum and maximum values in the array
        foreach (int num in nums)
        {
            if (num <= min)
                min = num;
            if (num > max)
                max = num;
        }

        // Calculate the GCD of the minimum and maximum
        for (int j = (min + max) / 2; j > 0; j--)
        {
            if (min % j == 0 && max % j == 0)
                return j;
        }

        return 1; // Default return value if no GCD is found
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(FindGCD(new int[] { 2, 5, 6, 9, 10 })); // Output: 1
    }
}
