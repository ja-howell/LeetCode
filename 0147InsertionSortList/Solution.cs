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
#nullable enable
public class Solution
{
    public ListNode InsertionSortList(ListNode head)
    {
        // check if null or 1 node
        if (head == null || head.next == null)
        {
            return head;
        }
        /*For each node in the list
        find where that node goes in the left side of the hand
        remove that node from where it currently is
        insert it into its place
        */
        ListNode i = head.next;
        ListNode prev = head;
        while (i != null)
        {
            ListNode j = head;
            if (j.val > i.val)
            {
                RemoveNode(ref prev, i);
                InsertNode(ref head, i, head);
            }
            else
            {
                while (j != i && j.next.val < i.val)
                {
                    j = j.next;
                }
                if (j.next != i)
                {
                    RemoveNode(ref prev, i);
                    InsertNode(ref j, i, j.next);
                }
                else
                {
                    prev = prev.next;
                }
            }
            i = prev.next;
        }
        return head;
    }

    public void RemoveNode(ref ListNode? head, ListNode x)
    {
        if (head == x)
        {
            head = null;
        }
        //TODO: If head == null 
        //TODO: If x is not in list
        ListNode runner = head;
        while (runner.next != x)
        {
            runner = runner.next;
        }
        runner.next = x.next;
    }

    public void InsertNode(ref ListNode? head, ListNode x, ListNode next)
    {
        if (next == head)
        {
            head = x;
            head.next = next;
            return;
        }
        ListNode runner = head;
        //TODO: What if head is empty?
        while (runner.next != next)
        {
            runner = runner.next;
        }
        x.next = next;
        runner.next = x;
    }
}