using System;
using System.Collections.Generic;

class LC933
{
    Queue<int> queue;

    public LC933()
    {
        queue = new Queue<int>();
    }

    public int Ping(int t)
    {
        queue.Enqueue(t);
        int lowerRange = t - 3000;
        while (queue.Peek() < lowerRange)
        {
            queue.Dequeue();
        }
        return queue.Count;
    }

    public static void Main(string[] args)
    {
        LC933 obj = new LC933();
        Console.WriteLine(obj.Ping(1));    // Output: 1
        Console.WriteLine(obj.Ping(100));  // Output: 2
        Console.WriteLine(obj.Ping(3001)); // Output: 3
        Console.WriteLine(obj.Ping(3002)); // Output: 3
        Console.WriteLine(obj.Ping(6000)); // Output: 4
    }
}
