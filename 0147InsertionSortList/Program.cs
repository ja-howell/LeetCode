using System;

class Program
{
    static void Main(string[] args)
    {
        ListNode? test1 = new ListNode(4);
        ListNode.append(ref test1, 2);
        ListNode.append(ref test1, 1);
        ListNode.append(ref test1, 3);
        ListNode.append(ref test1, 5);

        Solution solution = new Solution();
        ListNode result = solution.InsertionSortList(test1);
        ListNode.print(ref result);
    }
}