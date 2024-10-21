using System;

class LC231
{
    public static bool IsPowerOfTwoAlternativeSolution(int n)
    {
        // Check if n is greater than 0 and if n AND (n-1) is 0
        return n > 0 && (n & (n - 1)) == 0;
        // This method works because a power of two has exactly one bit set to 1 in its binary representation, 
        // and n & (n - 1) will clear that bit if n is a power of two, resulting in 0.
    }

    public static bool IsPowerOfTwo(int n)
    {
        if (n <= 0)
            return false;

        while (n % 2 == 0)
        {
            n /= 2;
        }

        return n == 1;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(IsPowerOfTwo(1));
        Console.WriteLine(IsPowerOfTwo(16));
        Console.WriteLine(IsPowerOfTwo(3));
        Console.WriteLine(IsPowerOfTwo(0));

        Console.WriteLine(IsPowerOfTwoAlternativeSolution(1));
        Console.WriteLine(IsPowerOfTwoAlternativeSolution(16));
        Console.WriteLine(IsPowerOfTwoAlternativeSolution(3));
        Console.WriteLine(IsPowerOfTwoAlternativeSolution(0));
    }
}
