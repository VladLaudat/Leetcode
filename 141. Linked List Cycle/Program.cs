  public class ListNode {
     public int val;
      public ListNode next;
      public ListNode(int x) {
          val = x;
          next = null;
      }
  }
 
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        if(head==null || head.next==null)
            return false;
        
        ListNode fastPointer = head;
        while(head.next != null && fastPointer!=null && fastPointer.next!=null)
        {
            
            head = head.next;
            fastPointer = fastPointer.next.next;
            if (head==fastPointer)
            {
                return true;
            }
        }
        return false;
    }
}