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
class LC25 {

    public static class ListNode {
        int val;
        ListNode next;
        ListNode() {}
        ListNode(int val) { this.val = val; }
        ListNode(int val, ListNode next) { this.val = val; this.next = next; }
    }

    public static ListNode reverseKGroup(ListNode head, int k) {
        int kCount = 0;
        ListNode tempHead = new ListNode(0);
        tempHead.next = head;
        ListNode currentNode = head, previousNode = tempHead;

        // Count the total number of nodes
        int totalNodes = 0;
        while (currentNode != null) {
            totalNodes++;
            currentNode = currentNode.next;
        }

        // Reset currentNode for main logic
        currentNode = head;

        // Process the list
        while (currentNode != null && totalNodes >= k) { // nsure at least k nodes exist before reversing
            if (kCount == k - 1) { // Condition to match correct k-sized groups
                // Reverse the list
                ListNode currNode = previousNode.next;
                for (int i = 1; i < k; i++) {
                    ListNode forward = currNode.next;
                    currNode.next = forward.next;
                    forward.next = previousNode.next;
                    previousNode.next = forward;
                }

                // Set previousNode for next sub-list
                previousNode = currNode;
                // Decrease totalNodes count by k
                totalNodes -= k;
                // Reset kCount after reversing the sub-list
                kCount = -1;
            }

            // Increment loop
            currentNode = currentNode.next;
            // Increment kCount
            kCount++;
        }
        return tempHead.next;
    }

    public static void main(String[] args) {
        ListNode head = new ListNode(1);
        ListNode temp = head;
        temp.next = new ListNode(2);
        temp = temp.next;
        temp.next = new ListNode(4);
        temp = temp.next;
        temp.next = new ListNode(5);
        temp = temp.next;
        temp.next = new ListNode(6);
        temp = temp.next;
        temp.next = new ListNode(7);
        temp = temp.next;
        temp.next = new ListNode(8);
        temp = temp.next;
        temp.next = new ListNode(9);
        temp = temp.next;

        ListNode result = reverseKGroup(head, 3);
        while (result != null) {
            System.out.print(result.val + " ");
            result = result.next;
        }
    }

}