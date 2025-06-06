class LC641 {

    int front, rear, size, capacity;
    int[] deque;

    public LC641(int k) {
        capacity = k;
        front = 1;
        rear = 0;
        size = 0;
        deque = new int[capacity];
    }
    
    public boolean insertFront(int value) {
        if(size == capacity)
            return false;
        
        front = (front - 1 + capacity) % capacity;
        deque[front] = value;
        size++;
        return true;
    }
    
    public boolean insertLast(int value) {
        if(size == capacity)
            return false;
        
        rear = (rear + 1) % capacity;
        deque[rear] = value;
        size++;
        return true;
    }
    
    public boolean deleteFront() {
        if(size == 0)
            return false;
        
        front = (front + 1) % capacity;
        size--;
        return true;
    }
    
    public boolean deleteLast() {
        if(size == 0)
            return false;
        
        rear = (rear - 1 + capacity) % capacity;
        size--;
        return true;
    }
    
    public int getFront() {
        return size == 0 ? -1 : deque[front];
    }
    
    public int getRear() {
        return size == 0 ? -1 : deque[rear];
    }
    
    public boolean isEmpty() {
        return size == 0;
    }
    
    public boolean isFull() {
        return size == capacity;
    }

    public static void main(String[] args) {
        LC641 circularDeque = new LC641(3); // set the size to be 3
        System.out.println(circularDeque.insertLast(1));  // return true
        System.out.println(circularDeque.insertLast(2));  // return true
        System.out.println(circularDeque.insertFront(3)); // return true
        System.out.println(circularDeque.insertFront(4)); // return false, the queue is full
        System.out.println(circularDeque.getRear());      // return 2
        System.out.println(circularDeque.isFull());       // return true
        System.out.println(circularDeque.deleteLast());    // return true
        System.out.println(circularDeque.insertFront(4)); // return true
        System.out.println(circularDeque.getFront());     // return 4
    }
}

/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * boolean param_1 = obj.insertFront(value);
 * boolean param_2 = obj.insertLast(value);
 * boolean param_3 = obj.deleteFront();
 * boolean param_4 = obj.deleteLast();
 * int param_5 = obj.getFront();
 * int param_6 = obj.getRear();
 * boolean param_7 = obj.isEmpty();
 * boolean param_8 = obj.isFull();
 */