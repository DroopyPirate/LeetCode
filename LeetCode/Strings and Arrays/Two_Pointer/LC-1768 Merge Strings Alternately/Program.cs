using System;

class LC1768
{
    public static string mergeAlternately(string word1, string word2)
    {
        int m = word1.Length, n = word2.Length;
        char[] merged = new char[m + n];

        int i = 0, j = 0, k = 0;
        while (i < m || j < n)
        {
            if (i < m) merged[k++] = word1[i++];
            if (j < n) merged[k++] = word2[j++];
        }
        return new string(merged);
    }

    public static void Main(string[] args)
    {
        string word1 = "abc", word2 = "pqr";
        Console.WriteLine(mergeAlternately(word1, word2)); // Output: "apbqcr"
        Console.WriteLine(mergeAlternately("ab", "pqrs")); // Output: "apbqrs"
        Console.WriteLine(mergeAlternately("abcd", "pq")); // Output: "apbqcd"
    }
}
