public class LC206
{
    public class ListNode
    {
        public int Val;
        public ListNode? Next; // Nullable because it can be null

        public ListNode() { }

        public ListNode(int val)
        {
            Val = val;
            Next = null;
        }

        public ListNode(int val, ListNode? next)
        {
            Val = val;
            Next = next;
        }
    }

    // LeetCode part starts here
    public ListNode? ReverseList(ListNode? head)
    {
        ListNode? currentNode = head;
        ListNode? previousNode = null;

        while (currentNode != null)
        {
            ListNode? nextNode = currentNode.Next;
            currentNode.Next = previousNode;
            previousNode = currentNode;
            currentNode = nextNode;
        }

        return previousNode;
    }
    // LeetCode part ends here

    public static void Main(string[] args)
    {
        LC206 lc206 = new LC206();
        ListNode head = new ListNode(1);
        head.Next = new ListNode(2);
        head.Next.Next = new ListNode(3);
        head.Next.Next.Next = new ListNode(4);
        head.Next.Next.Next.Next = new ListNode(5);

        ListNode? reversedHead = lc206.ReverseList(head);

        while (reversedHead != null)
        {
            Console.WriteLine(reversedHead.Val);
            reversedHead = reversedHead.Next;
        }
    }
}
