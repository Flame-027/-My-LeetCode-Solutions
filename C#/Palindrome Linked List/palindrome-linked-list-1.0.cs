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
public class Solution {
    public bool IsPalindrome(ListNode head) 
    {

        if(head.next == null)
           return true;

        var list = new List<int>(); 
        var current = head;

        while(!(current == null))
        {
            list.Add(current.val);
            current = current.next;
        }

        for (var i = 0; i < list.Count; i++)
        {
           if(!(list[i] == list[list.Count - 1 - i]))
              return false;
           
           if((list.Count - 1 - i) < i)
              return true;
        }
        return false;
    }
}