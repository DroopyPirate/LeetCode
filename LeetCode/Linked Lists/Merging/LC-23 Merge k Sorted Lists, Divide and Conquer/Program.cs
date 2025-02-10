using System;

public class LC23
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode() { }

        public ListNode(int val) { this.val = val; }

        public ListNode(int val, ListNode next)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static ListNode MergeKLists(ListNode[] lists)
    {
        if (lists.Length == 0) return null;
        return DivideAndConquer(lists, 0, lists.Length - 1);
    }

    private static ListNode DivideAndConquer(ListNode[] lists, int left, int right)
    {
        if (left == right) return lists[left];

        int mid = left + (right - left) / 2;
        ListNode l1 = DivideAndConquer(lists, left, mid);
        ListNode l2 = DivideAndConquer(lists, mid + 1, right);
        return MergeTwoLists(l1, l2);
    }

    private static ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        if (l1 == null) return l2;
        if (l2 == null) return l1;

        if (l1.val < l2.val)
        {
            l1.next = MergeTwoLists(l1.next, l2);
            return l1;
        }
        else
        {
            l2.next = MergeTwoLists(l1, l2.next);
            return l2;
        }
    }

    public static void Main(string[] args)
    {
        ListNode l1 = new ListNode(1);
        l1.next = new ListNode(4);
        l1.next.next = new ListNode(5);

        ListNode l2 = new ListNode(1);
        l2.next = new ListNode(3);
        l2.next.next = new ListNode(4);

        ListNode l3 = new ListNode(2);
        l3.next = new ListNode(6);

        ListNode[] lists = new ListNode[] { l1, l2, l3 };
        ListNode result = MergeKLists(lists);

        while (result != null)
        {
            Console.Write(result.val + " ");
            result = result.next;
        }
    }
}
