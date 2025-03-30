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
public class Solution
{
    public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        ListNode? newList = new ListNode();
        ListNode? r = newList;
        int carry = 0;

        while (l1 != null || l2 != null)
        {
            int sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
            carry = sum / 10;
            r.next = new ListNode(sum % 10);
            r = r.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }
        if (carry > 0)
        {
            r.next = new ListNode(carry);
        }
        return newList.next;
    }
}