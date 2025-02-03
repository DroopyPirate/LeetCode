using System;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }
}

public class LC92 {
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode prev = dummy;

        for (int i = 0; i < left - 1; i++)
            prev = prev.next;

        ListNode currentNode = prev.next;
        for (int i = 0; i < right - left; i++) {
            ListNode forwardNode = currentNode.next;
            currentNode.next = forwardNode.next;
            forwardNode.next = prev.next;
            prev.next = forwardNode;
        }
        return dummy.next;
    }

    public static void Main() {
        LC92 sol = new LC92();
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);
        head.next.next.next.next = new ListNode(5);

        ListNode result = sol.ReverseBetween(head, 2, 4);
        while (result != null) {
            Console.Write(result.val + " ");
            result = result.next;
        }
    }
}
