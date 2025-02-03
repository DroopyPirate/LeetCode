/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */


class LC92 {

    public static class ListNode {
        int val;
        ListNode next;
        ListNode(int val){
            this.val = val;
        }
    }

    public ListNode reverseBetween(ListNode head, int left, int right) {
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode prev = dummy;

        for(int i=0; i < left - 1; i++)
            prev = prev.next;
        
        ListNode currentNode = prev.next;
        for(int i=0; i < right - left; i++){
            ListNode forwardNode = currentNode.next;
            currentNode.next = forwardNode.next;
            forwardNode.next = prev.next;
            prev.next = forwardNode;
        }
        return dummy.next;
    }

    public static void main(String[] args) {
        LC92 sol = new LC92();
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);
        head.next.next.next.next = new ListNode(5);

        ListNode result = sol.reverseBetween(head, 2, 4);
        while(result != null){
            System.out.print(result.val + " ");
            result = result.next;
        }
    }
}