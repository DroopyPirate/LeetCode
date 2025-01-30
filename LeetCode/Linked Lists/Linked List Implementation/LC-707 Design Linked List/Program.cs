public class LC707
{
    private class Node
    {
        public int Data;
        public Node? Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    private int size;
    private Node? head;
    private Node? tail;

    public LC707()
    {
        size = 0;
        head = null;
        tail = null;
    }

    public int Get(int index)
    {
        if (index < 0 || index >= size)
            return -1;

        Node? currentNode = head;
        for (int i = 0; i < index; i++)
        {
            if (currentNode is not null) 
                currentNode = currentNode.Next;
        }
        
        return currentNode?.Data ?? -1;
    }

    public void AddAtHead(int val)
    {
        Node newNode = new Node(val);
        newNode.Next = head;
        head = newNode;
        if (size == 0) tail = head;
        size++;
    }

    public void AddAtTail(int val)
    {
        if (size == 0)
        {
            AddAtHead(val);
            return;
        }
        Node newNode = new Node(val);
        if (tail is not null)
            tail.Next = newNode;
        tail = newNode;
        size++;
    }

    public void AddAtIndex(int index, int val)
    {
        if (index < 0 || index > size)
            return;
        if (index == 0)
        {
            AddAtHead(val);
            return;
        }
        if (index == size)
        {
            AddAtTail(val);
            return;
        }
        
        Node? currentNode = head;
        for (int i = 0; i < index - 1; i++)
        {
            if (currentNode is not null)
                currentNode = currentNode.Next;
        }

        if (currentNode is not null)
        {
            Node newNode = new Node(val);
            newNode.Next = currentNode.Next;
            currentNode.Next = newNode;
            size++;
        }
    }

    public void DeleteAtIndex(int index)
    {
        if (index < 0 || index >= size)
            return;

        if (size == 1)
        {
            head = null;
            tail = null;
            size--;
            return;
        }

        if (index == 0)
        {
            head = head?.Next;
            if (head == null) tail = null;
        }
        else
        {
            Node? currentNode = head;
            for (int i = 0; i < index - 1; i++)
            {
                if (currentNode is not null)
                    currentNode = currentNode.Next;
            }
            if (currentNode?.Next is not null)
            {
                currentNode.Next = currentNode.Next.Next;
            }
            if (index == size - 1)
            {
                tail = currentNode;
            }
        }
        size--;
    }

    public static void Main(string[] args)
    {
        LC707 obj = new LC707();
        obj.AddAtHead(1);
        obj.AddAtTail(3);
        obj.AddAtIndex(1, 2);
        Console.WriteLine(obj.Get(1));
        obj.DeleteAtIndex(1);
        Console.WriteLine(obj.Get(1));
    }
}
