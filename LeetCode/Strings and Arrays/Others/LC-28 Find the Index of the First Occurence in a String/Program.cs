class LC28
{
    public static int StrStr(string haystack, string needle)
    {
        if (needle.Length > haystack.Length)
            return -1;

        int right = needle.Length, left = 0;
        while (right <= haystack.Length)
        {
            if (haystack.Substring(left, right - left).Equals(needle))
                return left;

            left++;
            right++;
        }

        return -1;
    }

    public static void Main(string[] args)
    {
        // Test cases
        Console.WriteLine(StrStr("hello", "ll")); // Output: 2
        Console.WriteLine(StrStr("aaaaa", "bba")); // Output: -1
        Console.WriteLine(StrStr("", "")); // Output: 0
        Console.WriteLine(StrStr("a", "a")); // Output: 0
        Console.WriteLine(StrStr("mississippi", "issip")); // Output: 4
    }
}
