/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;leet
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var remainder = 0;
        var result = new ListNode();
        var currentResultNode = result;
        do
        {
            if(currentResultNode.next != null)
                currentResultNode = currentResultNode.next;
            var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + remainder;
            remainder = 0;
            if(sum > 9) 
            {
                remainder = 1;
                sum -= 10;
            }
            currentResultNode.val = sum;
            currentResultNode.next = new ListNode(1);
            l1 = l1?.next;
            l2 = l2?.next;
        } while (l1 != null || l2 != null);
        if(remainder == 0)
            currentResultNode.next = null;
        return result;
    }
}
// @lc code=end

