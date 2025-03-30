using System;

class Program
{
    static void Main(string[] args)
    {
        // Example usage:
        ListNode? list1 = new ListNode(
            8
        );
        ListNode.append(ref list1, 4);
        ListNode? list2 = new ListNode(
            9
        );
        ListNode.append(ref list2, 4);
        ListNode.append(ref list2, 4);

        Solution solution = new Solution();
        ListNode? result = solution.AddTwoNumbers(list1, list2);
        ListNode? runner = result;
        while (runner != null)
        {
            Console.WriteLine(runner.val);
            runner = runner.next;
        }
    }
}