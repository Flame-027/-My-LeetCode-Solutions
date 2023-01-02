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

public class Solution 
{
    public ListNode MiddleNode(ListNode head) 
	{

     if (head.next == null)
         return head;

     var current = head;
     var count = 1;
     var list = new List<ListNode>();
   
     list.Add(head);
     while(!(current.next == null)) 
     {
         current = current.next;
         list.Add(current);
         count++;
     }     
     return list[count / 2];
    }
}