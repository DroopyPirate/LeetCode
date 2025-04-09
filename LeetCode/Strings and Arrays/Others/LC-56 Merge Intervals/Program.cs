using System;
using System.Collections.Generic;

public class LC56
{
    public static int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> merged = new List<int[]>();
        int[] prev = intervals[0];

        for (int i = 1; i < intervals.Length; i++)
        {
            int[] interval = intervals[i];
            if (interval[0] <= prev[1])
            {
                prev[1] = Math.Max(prev[1], interval[1]);
            }
            else
            {
                merged.Add(prev);
                prev = interval;
            }
        }

        merged.Add(prev);
        return merged.ToArray();
    }

    public static void Main(string[] args)
    {
        int[][] intervals = new int[][]
        {
            new int[] {1, 3},
            new int[] {2, 6},
            new int[] {8, 10},
            new int[] {15, 18}
        };

        int[][] mergedIntervals = Merge(intervals);
        foreach (int[] interval in mergedIntervals)
        {
            Console.WriteLine($"[{interval[0]}, {interval[1]}]");
        }
    }
    // Output: [1, 6], [8, 10], [15, 18]
}
