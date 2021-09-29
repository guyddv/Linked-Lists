using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public class MyLinkedList
    {
        public ListNode Head { get; set; }
        public ListNode Tail { get; set; }

        public ListNode empty;

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            Tail = null;
            empty = null;
        }

        /** Get the val of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (empty == null || index < 0)
            {
                return -1;
            }
            else
            {
                int i = 0;
                ListNode current = empty;
                while (current != null)
                {
                    if (i == index)
                    {
                        return current.val;
                    }
                    current = current.next;
                    i++;
                }
                return -1;
            }           
        }

        /** Add a node of val val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            empty = new ListNode(val, empty);
        }

        /** Append a node of val val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            if (empty == null)
            {
                return;
            }
            ListNode current = empty;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new ListNode(val, null);
        }

        /** Add a node of val val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (empty == null || index <= 0)
            {
                if (index <= 0)
                {
                    AddAtHead(val);
                }
                return;
            }
            int count = 0;
            ListNode current = empty;

            while (current != null)
            {
                count++;
                if (count == index)
                {
                    current.next = new ListNode(val, current.next);
                    break;
                }
                current = current.next;
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (empty == null)
                return;

            if (index == 0)
            {
                empty = empty.next;
                return;
            }

            int count = 0;
            ListNode current = empty;
            while (current != null)
            {
                count++;
                if (count == index)
                {
                    if (current.next != null)
                        current.next = current.next.next;
                    break;
                }

                current = current.next;
            }
        }
    }
}
