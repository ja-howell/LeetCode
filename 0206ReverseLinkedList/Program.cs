using System;

class Program
{
    static void Main(string[] args)
    {
        // Example usage:
        ListNode? head = new ListNode(
            1
        );
        ListNode.append(ref head, 2);
        ListNode.append(ref head, 3);
        ListNode.append(ref head, 4);
        ListNode.append(ref head, 5);

        // ListNode? head1 = new ListNode(
        //     1
        // );
        // ListNode? head2 = null;

        Solution solution = new Solution();
        ListNode? result = solution.ReverseList(head);
        ListNode? runner = result;
        while (runner != null)
        {
            Console.WriteLine(runner.val);
            runner = runner.next;
        }
    }
}