class LC459
{
    public static bool RepeatedSubstringPattern(string s)
    {
        string doubled = s + s;
        string sub = doubled.Substring(1, doubled.Length - 2);
        return sub.Contains(s);
    }

    public static void Main(string[] args)
    {
        // Test cases
        Console.WriteLine(RepeatedSubstringPattern("abab")); // true
        Console.WriteLine(RepeatedSubstringPattern("aba"));  // false
        Console.WriteLine(RepeatedSubstringPattern("abcabcabcabc")); // true
    }
}
