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
    public ListNode MiddleNode(ListNode head)
    {
        if(head.next == null) return head;
        ListNode i = head; ListNode j = head.next; int indexj = 1;int indexi = 0;
        while(j.next != null)
            { j = j.next; indexj++; }
        if(indexj%2==0) indexj=indexj/2;
        else indexj=indexj/2+1;
        while(indexi<indexj)
        {
            i=i.next;
            indexi++;
        }
        return i;
    }
}