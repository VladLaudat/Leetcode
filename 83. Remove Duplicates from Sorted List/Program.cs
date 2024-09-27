 public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }

public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null || head.next == null) return head;
        ListNode res = head;
        ListNode next;
        while (head.next != null)
        {
            next = head.next;
            while (next.val == head.val && next.next != null)
            {
                next = next.next;
            }
            head.next = next;
            if (next.val == head.val)
                head.next = null;
            head = next;
        }
        return res;
    }
}