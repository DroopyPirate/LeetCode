using System;
using System.Collections.Generic;

public class LC60
{
    public static string GetPermutation(int n, int k)
    {
        List<int> list = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            list.Add(i);
        }

        string returnString = "";
        k--;

        while (n > 0)
        {
            int factorialValue = Factorial(n - 1);
            int x = k / factorialValue;
            returnString += list[x];
            list.RemoveAt(x);
            n--;
            k %= factorialValue;
        }

        return returnString;
    }

    public static int Factorial(int n)
    {
        if (n == 1 || n == 0)
            return 1;
        return n * Factorial(n - 1);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(GetPermutation(3, 3)); // Output: "213"
        Console.WriteLine(GetPermutation(4, 9)); // Output: "2314"
        Console.WriteLine(GetPermutation(3, 1)); // Output: "123"
    }
}
