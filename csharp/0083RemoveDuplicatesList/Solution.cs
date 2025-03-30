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
    public ListNode? DeleteDuplicates(ListNode? head)
    {
        //Do Null Checks
        ListNode? runner = head;
        while (runner?.next != null)
        {
            if (runner.val == runner.next.val)
            {
                runner.next = runner.next.next;
            }
            else
            {
                runner = runner.next;
            }
        }
        return head;
    }
}