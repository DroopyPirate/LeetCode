using System;

class LC50
{
    public static double MyPow(double x, int n)
    {
        double answer = 1;
        long power = n;

        if (n < 0)
        {
            power = -power;
        }

        while (power > 0)
        {
            if (power % 2 == 1)
            {
                answer *= x;
                power--;
            }
            else
            {
                x *= x;
                power /= 2;
            }
        }

        if (n < 0)
        {
            answer = 1 / answer;
        }

        return answer;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(MyPow(2, 10));
        Console.WriteLine(MyPow(2.10000, 3));
        Console.WriteLine(MyPow(2.0000, -2));
        Console.WriteLine(MyPow(0.00001, 2147483647));
    }
}
