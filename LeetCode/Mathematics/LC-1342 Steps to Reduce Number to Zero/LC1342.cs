using System;

class LC1342
{
    public static int NumberOfSteps(int num)
    {
        int steps = 0;
        while (num > 0)
        {
            steps++;
            if (num % 2 == 1)
                num--;
            else
                num /= 2;
        }
        return steps;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(NumberOfSteps(14));   // Output: 6
        Console.WriteLine(NumberOfSteps(8));    // Output: 4
        Console.WriteLine(NumberOfSteps(123));  // Output: 12
    }
}
