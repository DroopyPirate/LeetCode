using System;

class LC263
{
    public static bool IsUgly(int n)
    {
        if (n <= 0)
            return false;

        while (n % 2 == 0)
            n /= 2;
        while (n % 3 == 0)
            n /= 3;
        while (n % 5 == 0)
            n /= 5;

        return n == 1;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(IsUgly(6));            // Output: True
        Console.WriteLine(IsUgly(1));            // Output: True
        Console.WriteLine(IsUgly(14));           // Output: False
        Console.WriteLine(IsUgly(-2147483648));  // Output: False
    }
}
