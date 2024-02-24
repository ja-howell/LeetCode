//We're comparing the first two numbers, taking the lesser one and putting it in a new list, taking the greater and storeing it.
// Take the stored value and compare to next item on the lesser one's list, etc...
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode newList;
        ListNode r;
        if (list1 != null && list2 != null) {
            if (list1.val > list2.val) {
                newList = list2;
                list2 = list2.next;
            } else {
                newList = list1;
                list1 = list1.next;
            }
        } else if (list1 == null) {
            return list2;
        } else {
            return list1;
        }
        r = newList;
        while (list1 != null && list2 != null) {
            if (list1.val > list2.val) {
                r.next = list2;
                list2 = list2.next;
            } else {
                r.next = list1;
                list1 = list1.next;
            }
            r = r.next;
        }
        if (list1 == null) {
            r.next = list2;
        } else if (list2 == null) {
            r.next = list1;
        }

        return newList;
    }
}