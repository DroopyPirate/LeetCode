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
class LC23 {

    public class ListNode {
        int val;
        ListNode next;
        ListNode() {}
        ListNode(int val) { this.val = val; }
        ListNode(int val, ListNode next) { this.val = val; this.next = next; }
    }

    public static ListNode mergeKLists(ListNode[] lists) {
        if(lists.length == 0) return null;
        return divideAndConquer(lists, 0, lists.length-1);
    }

    private static ListNode divideAndConquer(ListNode[] lists, int left, int right){
        if(left == right) return lists[left];

        int mid = left + (right - left) / 2;
        ListNode l1 = divideAndConquer(lists, left, mid);
        ListNode l2 = divideAndConquer(lists, mid+1, right);
        return mergeTwoLists(l1, l2);
    }


    private static ListNode mergeTwoLists(ListNode l1, ListNode l2){
        if(l1 == null) return l2;
        if(l2 == null) return l1;

        if(l1.val < l2.val){
            l1.next = mergeTwoLists(l1.next, l2);
            return l1;
        }
        else{
            l2.next = mergeTwoLists(l1, l2.next);
            return l2;
        }
    }

    public static void main(String[] args) {
        ListNode l1 = new LC23().new ListNode(1);
        l1.next = new LC23().new ListNode(4);
        l1.next.next = new LC23().new ListNode(5);

        ListNode l2 = new LC23().new ListNode(1);
        l2.next = new LC23().new ListNode(3);
        l2.next.next = new LC23().new ListNode(4);

        ListNode l3 = new LC23().new ListNode(2);
        l3.next = new LC23().new ListNode(6);

        ListNode[] lists = new ListNode[]{l1, l2, l3};
        ListNode result = mergeKLists(lists);
        while(result != null){
            System.out.print(result.val + " ");
            result = result.next;
        }
    }
}