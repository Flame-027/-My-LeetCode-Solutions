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
    public ListNode MiddleNode(ListNode head) {

    if (head.next == null)
        return head;

       var current = head;
       var count = 1;

       while(!(current.next == null)) 
       {
           current = current.next;
           count++;
       }

       var halfPoint = (count / 2) + 1;       
       current = head;
       count = 1;

       while (count < halfPoint)
       {
          current = current.next;
          count++;
       }
       return current;
    }
}