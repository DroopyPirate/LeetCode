/**
 * Definition for singly-linked list.
 */

class LC206 {

    public class ListNode {
        int val;
        ListNode next;
        ListNode() {}
        ListNode(int val) { this.val = val; }
        ListNode(int val, ListNode next) { this.val = val; this.next = next; }
    }


    
    //LeetCode Part starts here
    public ListNode reverseList(ListNode head) {
        ListNode currentNode = head;
        ListNode previousNode = null;
        while(currentNode != null){
            ListNode nextNode = currentNode.next;
            currentNode.next = previousNode;
            previousNode = currentNode;
            currentNode = nextNode;
        }
        return previousNode;
    }
    //Leetcode part ends here


    public static void main(String[] args) {
        LC206 lc206 = new LC206();
        ListNode head = lc206.new ListNode(1);
        head.next = lc206.new ListNode(2);
        head.next.next = lc206.new ListNode(3);
        head.next.next.next = lc206.new ListNode(4);
        head.next.next.next.next = lc206.new ListNode(5);
        ListNode reversedHead = lc206.reverseList(head);
        while(reversedHead != null){
            System.out.println(reversedHead.val);
            reversedHead = reversedHead.next;
        }
    }
}