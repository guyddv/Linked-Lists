using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    /*
     * ListNode
     * 
     * This ListNode follows the naming conventions and access levels set by LeetCode.  We are not using the system type LinkedListNode<int> in this case in order to process our code on leetcode. 
     * 
     * LeetCode definition for singly-linked list.
     * 
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int val=0, ListNode next=null) {
     *         this.val = val;
     *         this.next = next;
     *     }
     * }
     */
    public class ListNode
    {
        public int val { get; set; }
        public ListNode next { get; set; }
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }  
    }
}
