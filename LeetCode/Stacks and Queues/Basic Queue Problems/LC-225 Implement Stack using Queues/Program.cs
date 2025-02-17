using System;
using System.Collections.Generic;

class LC225
{
    static Queue<int> queue1 = new Queue<int>();
    static Queue<int> queue2 = new Queue<int>();

    public LC225()
    {
    }

    public static void Push(int x)
    {
        queue1.Enqueue(x);
    }

    public static int Pop()
    {
        while (queue1.Count > 1)
        {
            queue2.Enqueue(queue1.Dequeue());
        }
        int topElement = queue1.Dequeue();
        SwapQueues();
        return topElement;
    }

    public static int Top()
    {
        while (queue1.Count > 1)
        {
            queue2.Enqueue(queue1.Dequeue());
        }
        int topElement = queue1.Peek();
        queue2.Enqueue(queue1.Dequeue());
        SwapQueues();
        return topElement;
    }

    public static bool Empty()
    {
        return queue1.Count == 0;
    }

    public static void SwapQueues()
    {
        Queue<int> temp = queue1;
        queue1 = queue2;
        queue2 = temp;
    }

    public static void Main(string[] args)
    {
        Push(1);
        Push(2);
        Console.WriteLine(Top());  // returns 2
        Console.WriteLine(Pop());  // returns 2
        Console.WriteLine(Empty()); // returns false
    }
}
