using System;

class LC641
{
    int front, rear, size, capacity;
    int[] deque;

    public LC641(int k)
    {
        capacity = k;
        front = 1;
        rear = 0;
        size = 0;
        deque = new int[capacity];
    }

    public bool insertFront(int value)
    {
        if (size == capacity)
            return false;

        front = (front - 1 + capacity) % capacity;
        deque[front] = value;
        size++;
        return true;
    }

    public bool insertLast(int value)
    {
        if (size == capacity)
            return false;

        rear = (rear + 1) % capacity;
        deque[rear] = value;
        size++;
        return true;
    }

    public bool deleteFront()
    {
        if (size == 0)
            return false;

        front = (front + 1) % capacity;
        size--;
        return true;
    }

    public bool deleteLast()
    {
        if (size == 0)
            return false;

        rear = (rear - 1 + capacity) % capacity;
        size--;
        return true;
    }

    public int getFront()
    {
        return size == 0 ? -1 : deque[front];
    }

    public int getRear()
    {
        return size == 0 ? -1 : deque[rear];
    }

    public bool isEmpty()
    {
        return size == 0;
    }

    public bool isFull()
    {
        return size == capacity;
    }

    public static void Main(string[] args)
    {
        LC641 circularDeque = new LC641(3); // set the size to be 3
        Console.WriteLine(circularDeque.insertLast(1));  // return true
        Console.WriteLine(circularDeque.insertLast(2));  // return true
        Console.WriteLine(circularDeque.insertFront(3)); // return true
        Console.WriteLine(circularDeque.insertFront(4)); // return false, the queue is full
        Console.WriteLine(circularDeque.getRear());      // return 2
        Console.WriteLine(circularDeque.isFull());       // return true
        Console.WriteLine(circularDeque.deleteLast());   // return true
        Console.WriteLine(circularDeque.insertFront(4)); // return true
        Console.WriteLine(circularDeque.getFront());     // return 4
    }
}

/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * bool param_1 = obj.insertFront(value);
 * bool param_2 = obj.insertLast(value);
 * bool param_3 = obj.deleteFront();
 * bool param_4 = obj.deleteLast();
 * int param_5 = obj.getFront();
 * int param_6 = obj.getRear();
 * bool param_7 = obj.isEmpty();
 * bool param_8 = obj.isFull();
 */
