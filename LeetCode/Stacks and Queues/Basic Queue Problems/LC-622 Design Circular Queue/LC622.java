class LC622 {

    int front, size, capacity;
    int [] queue;

    public LC622(int k) {
        capacity = k;
        size = 0;
        front = 0;
        queue = new int[capacity];
    }
    
    public boolean enQueue(int value) {
        if(size == capacity)
            return false;
        int insertIndex = (front + size) % capacity;
        queue[insertIndex] = value;
        size++;
        return true;
    }
    
    public boolean deQueue() {
        if(size == 0)
            return false;
        front = (front + 1) % capacity;
        size--;
        return true;
    }
    
    public int Front() {
        if(size == 0)
            return -1;
        return queue[front];
    }
    
    public int Rear() {
        if(size == 0)
            return -1;
        int rearIndex = (front + size - 1) % capacity;
        return queue[rearIndex];
    }
    
    public boolean isEmpty() {
        return size == 0;
    }
    
    public boolean isFull() {
        return size == capacity;
    }

    public static void main(String[] args) {
        LC622 myCircularQueue = new LC622(3);
        System.out.println(myCircularQueue.enQueue(1)); // return true
        System.out.println(myCircularQueue.enQueue(2)); // return true
        System.out.println(myCircularQueue.enQueue(3)); // return true
        System.out.println(myCircularQueue.enQueue(4)); // return false, the queue is full
        System.out.println(myCircularQueue.Rear());      // return 3
        System.out.println(myCircularQueue.isFull());   // return true
        System.out.println(myCircularQueue.deQueue());   // return true
        System.out.println(myCircularQueue.enQueue(4));  // return true
        System.out.println(myCircularQueue.Rear());      // return 4
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * boolean param_1 = obj.enQueue(value);
 * boolean param_2 = obj.deQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * boolean param_5 = obj.isEmpty();
 * boolean param_6 = obj.isFull();
 */