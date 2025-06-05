class LC622
{
    int front, size, capacity;
    int[] queue;

    public LC622(int k)
    {
        capacity = k;
        size = 0;
        front = 0;
        queue = new int[capacity];
    }

    public bool enQueue(int value)
    {
        if (size == capacity)
            return false;

        int insertIndex = (front + size) % capacity;
        queue[insertIndex] = value;
        size++;
        return true;
    }

    public bool deQueue()
    {
        if (size == 0)
            return false;

        front = (front + 1) % capacity;
        size--;
        return true;
    }

    public int Front()
    {
        if (size == 0)
            return -1;

        return queue[front];
    }

    public int Rear()
    {
        if (size == 0)
            return -1;

        int rearIndex = (front + size - 1) % capacity;
        return queue[rearIndex];
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
        LC622 myCircularQueue = new LC622(3);
        Console.WriteLine(myCircularQueue.enQueue(1)); // return true
        Console.WriteLine(myCircularQueue.enQueue(2)); // return true
        Console.WriteLine(myCircularQueue.enQueue(3)); // return true
        Console.WriteLine(myCircularQueue.enQueue(4)); // return false, the queue is full
        Console.WriteLine(myCircularQueue.Rear());     // return 3
        Console.WriteLine(myCircularQueue.isFull());   // return true
        Console.WriteLine(myCircularQueue.deQueue());  // return true
        Console.WriteLine(myCircularQueue.enQueue(4)); // return true
        Console.WriteLine(myCircularQueue.Rear());     // return 4
    }
}

/*
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.enQueue(value);
 * bool param_2 = obj.deQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.isEmpty();
 * bool param_6 = obj.isFull();
 */
