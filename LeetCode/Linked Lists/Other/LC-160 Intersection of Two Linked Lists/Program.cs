using System;
using System.Collections.Generic;

public class LC160
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

    public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA == null || headB == null) return null;
        HashSet<ListNode> set = new HashSet<ListNode>();

        while (headA != null)
        {
            set.Add(headA);
            headA = headA.next;
        }

        while (headB != null)
        {
            if (set.Contains(headB)) return headB;
            headB = headB.next;
        }

        return null;
    }

    public static void Main(string[] args)
    {
        ListNode headA = new ListNode(4);
        headA.next = new ListNode(1);
        headA.next.next = new ListNode(8);
        headA.next.next.next = new ListNode(4);
        headA.next.next.next.next = new ListNode(5);

        ListNode headB = new ListNode(5);
        headB.next = new ListNode(0);
        headB.next.next = new ListNode(1);
        headB.next.next.next = headA.next.next; // Intersection occurs here

        ListNode res = GetIntersectionNode(headA, headB);
        Console.WriteLine(res != null ? res.val.ToString() : "No intersection");
    }
}
