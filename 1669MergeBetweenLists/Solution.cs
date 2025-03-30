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
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
    {
        ListNode end = list1;
        ListNode start = list1;
        for (int i = 0; i < (a - 1); i++)
        {
            start = start.next;
        }
        end = start;
        for (int i = (a - 1); i < (b + 1); i++)
        {
            end = end.next;
        }
        ListNode runner = list2;
        while (runner.next != null)
        {
            runner = runner.next;
        }
        start.next = list2;
        runner.next = end;
        return list1;
    }
}