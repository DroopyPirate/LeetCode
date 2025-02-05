import java.util.HashSet;

/**
 * Definition for singly-linked list.
 * class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */

public class LC142 {

    public static class ListNode {
        int val;
        ListNode next;
        ListNode(int x) {
            val = x;
            next = null;
        }
    }

     // With HashSet O(1) time O(n) space
    public ListNode detectCycleByHashSet(ListNode head) {
        HashSet<ListNode> set = new HashSet<ListNode>();
        while(head != null){
            if(set.contains(head))
                return head;
            set.add(head);
            head = head.next;
        }
        return null;
    }

    // fast and slow pointer O(1) time O(1) space
    public ListNode detectCycleByTwoPointer(ListNode head) {
        ListNode fast = head, slow = head;

        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;

            if(fast == slow)
                break;
        }

        if(fast == null || fast.next == null)
            return null;
        
        fast = head;
        while(fast != slow){
            fast = fast.next;
            slow = slow.next;
        }
        return slow;
    }

    public static void main(String[] args) {
        LC142 lc142 = new LC142();
        ListNode head = new ListNode(3);
        head.next = new ListNode(2);
        head.next.next = new ListNode(0);
        head.next.next.next = new ListNode(-4);
        head.next.next.next.next = head.next;
        System.out.println(lc142.detectCycleByHashSet(head).val);
        System.out.println(lc142.detectCycleByTwoPointer(head).val);
    }
}