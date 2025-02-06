using System;

public class LC21
{
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode() {}
        public ListNode(int val) { this.val = val; }
        public ListNode(int val, ListNode next) { this.val = val; this.next = next; }
    }

    public static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        ListNode? result = new ListNode(0);
        ListNode? resultHead = result;
        
        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                result.next = list1;
                list1 = list1?.next;
            }
            else
            {
                result.next = list2;
                list2 = list2?.next;
            }
            result = result.next;
        }

        if (list1 == null)
        {
            result.next = list2;
        }
        else if (list2 == null)
        {
            result.next = list1;
        }

        return resultHead?.next;
    }

    public static void Main()
    {
        ListNode? list1 = new(1)
        {
            next = new ListNode(2)
        };
        list1.next.next = new ListNode(4);

        ListNode? list2 = new(1)
        {
            next = new ListNode(3)
        };
        list2.next.next = new ListNode(4);

        ListNode? result = MergeTwoLists(list1, list2);
        while (result != null)
        {
            Console.WriteLine(result.val);
            result = result.next;
        }
    }
}
