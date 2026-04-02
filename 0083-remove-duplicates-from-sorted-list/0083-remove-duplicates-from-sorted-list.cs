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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode res = head;
        while(res != null && res.next != null){
            if(res.val == res.next.val){
                res.next = res.next.next;
            }else{
                res = res.next;
            }
        }
        return head;
    }
}