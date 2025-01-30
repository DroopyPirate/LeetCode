import java.util.HashSet;
public class LC141 {

    public class ListNode {
        int val;
        ListNode next;
        ListNode(int x) {
            val = x;
            next = null;
        }
    }

    //LeetCode part starts here
    public static boolean hasCycleTwoPointerApproach(ListNode head) {
        ListNode slowPointer = head, fastPointer = head;
        while(fastPointer != null && fastPointer.next != null){
            slowPointer = slowPointer.next;
            fastPointer = fastPointer.next.next;
            if(slowPointer == fastPointer)
                return true;
        }
        return false;
    }

    public static boolean hasCycleHashSetApproach(ListNode head) {
        HashSet<ListNode> visitedNodes = new HashSet<ListNode>();
        ListNode currentNode = head;
        while(currentNode != null){
            if(visitedNodes.contains(currentNode))
                return true;
            visitedNodes.add(currentNode);
            currentNode = currentNode.next;
        }
        return false;
    }
    //LeetCode part ends here

    public static void main(String[] args) {
        LC141 lc141 = new LC141();
        ListNode head = lc141.new ListNode(3);
        head.next = lc141.new ListNode(2);
        head.next.next = lc141.new ListNode(0);
        head.next.next.next = lc141.new ListNode(-4);
        head.next.next.next.next = head.next;
        System.out.println(hasCycleTwoPointerApproach(head) + " Two Pointer Approach");
        System.out.println(hasCycleHashSetApproach(head) + " HashSet Approach");
    }
}