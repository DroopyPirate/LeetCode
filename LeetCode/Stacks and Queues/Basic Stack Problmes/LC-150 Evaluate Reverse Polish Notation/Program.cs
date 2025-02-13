using System;
using System.Collections.Generic;

class LC150
{
    public static int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new Stack<int>();
        foreach (string str in tokens)
        {
            switch (str)
            {
                case "+":
                    stack.Push(stack.Pop() + stack.Pop());
                    break;
                case "-":
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(b - a);
                    break;
                case "*":
                    stack.Push(stack.Pop() * stack.Pop());
                    break;
                case "/":
                    int divisor = stack.Pop();
                    int dividend = stack.Pop();
                    stack.Push(dividend / divisor);
                    break;
                default:
                    stack.Push(int.Parse(str));
                    break;
            }
        }
        return stack.Pop();
    }

    public static void Main()
    {
        string[] tokens = { "2", "1", "+", "3", "*" };
        Console.WriteLine(EvalRPN(tokens)); // Output: 9
    }
}
