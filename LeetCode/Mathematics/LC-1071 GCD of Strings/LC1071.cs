using System;

class LC1071
{
    public static string GcdOfStrings(string str1, string str2)
    {
        if ((str1 + str2) != (str2 + str1))
            return "";

        int gcd = FindGcd(str1.Length, str2.Length);

        return str1.Substring(0, gcd);
    }

    public static int FindGcd(int a, int b)
    {
        return b == 0 ? a : FindGcd(b, a % b);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(GcdOfStrings("ABCABC", "ABC")); // Output: "ABC"
        Console.WriteLine(GcdOfStrings("ABABAB", "ABAB")); // Output: "ABAB"
        Console.WriteLine(GcdOfStrings("LEET", "CODE"));   // Output: ""
    }
}
