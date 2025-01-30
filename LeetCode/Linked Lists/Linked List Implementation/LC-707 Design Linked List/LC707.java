class LC707 {

    private class Node {
        int data;
        Node next;

        Node(int data) {
            this.data = data;
            next = null;
        }
    }

    private int size;
    private Node head;
    private Node tail;

    public LC707() {
        size = 0;
        head = null;
        tail = null;
    }

    public int get(int index) {
        if (index < 0 || index >= size)
            return -1;
        Node currentNode = head;
        for (int i = 0; i < index; i++)
            currentNode = currentNode.next;
        return currentNode.data;
    }

    public void addAtHead(int val) {
        Node newNode = new Node(val);
        newNode.next = head;
        head = newNode;
        if (size == 0) tail = head;
        size++;
    }

    public void addAtTail(int val) {
        if (size == 0) {
            addAtHead(val);
            return;
        } 
        Node newNode = new Node(val);
        tail.next = newNode;
        tail = newNode;
        size++;
    }

    public void addAtIndex(int index, int val) {
        if (index < 0 || index > size)
            return;
        if (index == 0) {
            addAtHead(val);
            return;
        } 
        if (index == size) {
            addAtTail(val);
            return;
        }
        Node currentNode = head;
        for (int i = 0; i < index - 1; i++)
            currentNode = currentNode.next;
        Node newNode = new Node(val);
        newNode.next = currentNode.next;
        currentNode.next = newNode;
        size++;
    }

    public void deleteAtIndex(int index) {
        if (index < 0 || index >= size)
            return;
        if (size == 1) {
            head = null;
            tail = null;
            size--;
            return;
        }
        if (index == 0) {
            head = head.next;
            if (head == null) tail = null;
        } else {
            Node currentNode = head;
            for (int i = 0; i < index - 1; i++)
                currentNode = currentNode.next;
            currentNode.next = currentNode.next.next;
            if (index == size - 1) {
                tail = currentNode;
            }
        }
        size--;
    }

    public static void main(String[] args) {
        LC707 obj = new LC707();
        obj.addAtHead(1);
        obj.addAtTail(3);
        obj.addAtIndex(1, 2);
        System.out.println(obj.get(1));
        obj.deleteAtIndex(1);
        System.out.println(obj.get(1));
    }
}
