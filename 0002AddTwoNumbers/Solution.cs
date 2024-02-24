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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode newList = new ListNode();
        ListNode r = newList;
        int carry = 0;

        while (l1 != null && l2 != null) {
            int digit = l1.val + l2.val + carry;
            if (digit >= 10) {
                digit = digit % 10;
                carry = 1;
            } else {
                carry = 0;
            }
            r.next = new ListNode(digit);
            r = r.next;
            l1 = l1.next;
            l2 = l2.next;
        }
        if (l1 != null) {
            while (l1 != null) {
                int digit = l1.val + carry;
                if (digit >= 10) {
                    digit = digit % 10;
                    carry = 1;
                } else {
                    carry = 0;
                }
                r.next = new ListNode(digit);
                r = r.next;
                l1 = l1.next;
            }
        } else if (l2 != null) {
            while (l2 != null) {
                int digit = + l2.val + carry;
                if (digit >= 10) {
                    digit = digit % 10;
                    carry = 1;
                } else {
                    carry = 0;
                }
                r.next = new ListNode(digit);
                r = r.next;
                l2 = l2.next;
            }
        }
        if (carry > 0) {
            r.next = new ListNode(carry);
        }
        return newList.next;
    }
}