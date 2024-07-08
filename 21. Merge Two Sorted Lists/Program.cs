

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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode list3 = new ListNode();
        if (list1 == null)
            return list2;
        if (list2 == null)
            return list1;
        if (list1.val <= list2.val)
        {
            list3.val = list1.val;
            list1 = list1.next;
        }
        else
        {
            list3.val = list2.val;
            list2 = list2.next;
        }
        ListNode solution = list3;
        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                list3.next = list1;
                list1 = list1.next;
            }
            else
            {
                list3.next = list2;
                list2 = list2.next;
            }
            list3 = list3.next;
        }

        while (list1 != null)
        {
            list3.next = list1;
            list1 = list1.next;
            list3 = list3.next;
        }

        while (list2 != null)
        {
            list3.next = list2;
            list2 = list2.next;
            list3 = list3.next;
        }

        return solution;

    }
}