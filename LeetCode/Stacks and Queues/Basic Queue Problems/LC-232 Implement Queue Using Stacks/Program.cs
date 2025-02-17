using System;
using System.Collections.Generic;

class LC232
{
    static Stack<int> inputStack = new Stack<int>();
    static Stack<int> outputStack = new Stack<int>();

    public LC232() { }

    public static void Push(int x)
    {
        inputStack.Push(x);
    }

    public static int Pop()
    {
        if (outputStack.Count == 0)
        {
            while (inputStack.Count > 0)
            {
                outputStack.Push(inputStack.Pop());
            }
        }
        return outputStack.Pop();
    }

    public static int Peek()
    {
        if (outputStack.Count == 0)
        {
            while (inputStack.Count > 0)
            {
                outputStack.Push(inputStack.Pop());
            }
        }
        return outputStack.Peek();
    }

    public static bool Empty()
    {
        return outputStack.Count == 0 && inputStack.Count == 0;
    }

    public static void Main(string[] args)
    {
        Push(1);
        Push(2);
        Console.WriteLine(Peek()); // returns 1
        Console.WriteLine(Pop());  // returns 1
        Console.WriteLine(Empty()); // returns false
    }
}
