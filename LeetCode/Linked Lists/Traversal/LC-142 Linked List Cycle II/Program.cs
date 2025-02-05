using System;
using System.Collections.Generic;

public class LC142
{
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    // With HashSet O(1) time O(n) space
    public ListNode? DetectCycleByHashSet(ListNode? head)
    {
        HashSet<ListNode> set = new HashSet<ListNode>();
        while (head != null)
        {
            if (set.Contains(head))
                return head;
            set.Add(head);
            head = head.next;
        }
        return null;
    }

    // Fast and slow pointer O(1) time O(1) space
    public ListNode? DetectCycleByTwoPointer(ListNode? head)
    {
        ListNode? fast = head, slow = head;

        while (fast != null && fast.next != null)
        {
            slow = slow?.next;
            fast = fast.next.next;

            if (fast == slow)
                break;
        }

        if (fast == null || fast.next == null)
            return null;

        fast = head;
        while (fast != slow)
        {
            fast = fast?.next;
            slow = slow?.next;
        }
        return slow;
    }

    public static void Main()
    {
        LC142 lc142 = new LC142();
        ListNode head = new ListNode(3);
        head.next = new ListNode(2);
        head.next.next = new ListNode(0);
        head.next.next.next = new ListNode(-4);
        head.next.next.next.next = head.next;
        Console.WriteLine(lc142.DetectCycleByHashSet(head)?.val);
        Console.WriteLine(lc142.DetectCycleByTwoPointer(head)?.val);
    }
}
