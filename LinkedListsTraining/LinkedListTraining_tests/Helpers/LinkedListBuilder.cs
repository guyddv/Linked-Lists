using LinkedListsTraining;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTraining_tests.Helpers
{
    public static class LinkedListBuilder
    {
        /*
         * Linked List Builder
         * 
         * Normally we would utalize our frameworks when using LinkedLists and not write a method like bleow to create a LinkedList.  This list builder, however, is an alternative solution for us to work within the parameters and naming conventions of the problems posted at LeetCode.
         */
        public static ListNode CreateSinglyLinkedList(int[] list) => CreateList(list, out _);

        public static ListNode CreateSinglyLinkedList(int[] list, out ListNode tail) => CreateList(list, out tail);

        private static ListNode CreateList(int[] list, out ListNode tail)
        {
            ListNode head = null;
            tail = null;

            if (list.Length > 0) tail = head = new ListNode(list[0]);

            if (list.Length > 1)
            {
                for (var i = 1; i < list.Length; i++)
                {
                    tail = tail.next = new ListNode(list[i]);
                }
            }

            return head;
        }
    }
}
