public class LC141
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    //LeetCode  part starts here
    public static bool HasCycleTwoPointerApproach(ListNode head)
    {
        ListNode slowPointer = head, fastPointer = head;
        while (fastPointer != null && fastPointer.next != null)
        {
            slowPointer = slowPointer.next;
            fastPointer = fastPointer.next.next;
            if (slowPointer == fastPointer)
                return true;
        }
        return false;
    }

    public static bool HasCycleHashSetApproach(ListNode head)
    {
        HashSet<ListNode> visitedNodes = new HashSet<ListNode>();
        ListNode currentNode = head;
        while (currentNode != null)
        {
            if (visitedNodes.Contains(currentNode))
                return true;
            visitedNodes.Add(currentNode);
            currentNode = currentNode.next;
        }
        return false;
    }

    //LeetCode part ends here

    public static void Main()
    {
        LC141 lc141 = new LC141();
        ListNode head = new ListNode(3);
        head.next = new ListNode(2);
        head.next.next = new ListNode(0);
        head.next.next.next = new ListNode(-4);
        head.next.next.next.next = head.next; // Creating a cycle

        Console.WriteLine(HasCycleTwoPointerApproach(head) + " Two Pointer Approach");
        Console.WriteLine(HasCycleHashSetApproach(head) + " HashSet Approach");
    }
}
