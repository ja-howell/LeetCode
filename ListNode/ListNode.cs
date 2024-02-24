public class ListNode {
    public int val;
    public ListNode? next;
    public ListNode(int val=0, ListNode? next=null) {
        this.val = val;
        this.next = next;
    }

    public static void appendListNode(ref ListNode? l, ListNode? x) {
        if (l == null){
            l = x;
            return;
        }
        appendListNode(ref l.next, x);
    }
}


 