using System;

public class LC62
{
    public static int UniquePaths(int m, int n)
    {
        if (m == 1 || n == 1)
            return 1;

        int[] aboveRow = new int[n];
        Array.Fill(aboveRow, 1);

        for (int row = 1; row < m; row++)
        {
            int[] currentRow = new int[n];
            currentRow[0] = 1;
            for (int col = 1; col < n; col++)
            {
                currentRow[col] = currentRow[col - 1] + aboveRow[col];
            }
            aboveRow = currentRow;
        }

        return aboveRow[n - 1];
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(UniquePaths(3, 7)); // Output: 28
        Console.WriteLine(UniquePaths(3, 2)); // Output: 3
        Console.WriteLine(UniquePaths(7, 3)); // Output: 28
        Console.WriteLine(UniquePaths(3, 3)); // Output: 6
    }
}
