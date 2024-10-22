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
    public void ReorderList(ListNode head)
    {
        if (head.next == null) return;
        ListNode slowPointer = head;
        ListNode fastPointer = head;
        //find middle
        while (fastPointer.next != null && fastPointer.next.next != null)
        {
            slowPointer = slowPointer.next;
            fastPointer = fastPointer.next.next;
        }
        ListNode secondList = slowPointer.next;
        slowPointer.next = null;

        //Reverse second list
        ListNode last = null;
        while (secondList != null)
        {
            ListNode next = secondList.next;
            secondList.next = last;
            last = secondList;
            secondList = next;
        }
        secondList = last;
        ListNode firstListNext = head.next;
        ListNode secondListNext = secondList.next;


        while (head != null && secondList!=null)
        {
            head.next = secondList;
            secondList.next = firstListNext;
            head = firstListNext;
            secondList = secondListNext;

            if (firstListNext != null && secondListNext != null)
            {
                firstListNext = firstListNext.next;
                secondListNext = secondListNext.next;
            }
        }

    }
}