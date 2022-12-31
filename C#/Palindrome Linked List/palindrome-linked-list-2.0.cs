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

//much more readable and has better runtime then 1.0 solution
public class Solution {
    public bool IsPalindrome(ListNode head) {

        if(head.next == null)
           return true;

        var list = new List<int>(); 
        var current = head;

        while(!(current == null))
        {
            list.Add(current.val);
            current = current.next;
        }

        var reversed = new List<int>(list);
        reversed.Reverse();

       if (list.SequenceEqual(reversed))
          return true;
        else
           return false;
    }
}