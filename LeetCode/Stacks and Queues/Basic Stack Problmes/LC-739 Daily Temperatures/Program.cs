using System;
using System.Collections.Generic;

class LC739
{
    public static int[] DailyTemperatures(int[] temperatures)
    {
        int[] result = new int[temperatures.Length];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < temperatures.Length; i++)
        {
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
            {
                int index = stack.Pop();
                result[index] = i - index;
            }
            stack.Push(i);
        }
        return result;
    }

    public static void Main()
    {
        int[] temperatures = { 73, 74, 75, 71, 69, 72, 76, 73 };
        int[] result = DailyTemperatures(temperatures);
        
        foreach (int i in result)
        {
            Console.Write(i + " ");
        }
    }
}
