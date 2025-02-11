using System;
using System.Collections.Generic;

class LC155 {
    private Stack<int> minStack;
    private Stack<int> stack;

    public LC155() {
        minStack = new Stack<int>();
        stack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if (minStack.Count == 0 || val <= minStack.Peek()) {
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        if (stack.Pop() == minStack.Peek()) {
            minStack.Pop();
        }
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }

    public static void Main(string[] args) {
        LC155 obj = new LC155();
        obj.Push(-2);
        obj.Push(0);
        obj.Push(-3);
        Console.WriteLine(obj.GetMin()); // Returns -3
        obj.Pop();
        Console.WriteLine(obj.Top());    // Returns 0
        Console.WriteLine(obj.GetMin()); // Returns -2
    }
}
