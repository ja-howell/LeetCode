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
using System;

class Program {
    static void Main(string[] args) {
        // Example usage:
        ListNode list1 = new ListNode(
            1,
            new ListNode (
                2,
                new ListNode (
                    4
                )
            )
        );
        ListNode list2 = new ListNode(
            1,
            new ListNode (
                3,
                new ListNode (
                    4
                )
            )
        );

        Solution solution = new Solution();
        ListNode result = solution.MergeTwoLists(list1, list2);
        ListNode? runner = list1;
        while (runner != null) {
            Console.WriteLine(runner.val);
            runner = runner.next;
        }
    }
}