using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.CycleDetection
{
    public class Result
    {
        /* For your reference:
        *
        * SinglyLinkedListNode {
        *     int data;
        *     SinglyLinkedListNode next;
        * }
        */
        static bool hasCycle(SinglyLinkedListNode head) {
        if( head == null ) return false;
        bool result = false, loop = true;
        SinglyLinkedListNode slow = head, fast = head;
    
        while (loop)
        {
            try
            {
                slow = slow.next;
                fast = fast.next.next.next;
                
                if( slow == fast)
                {
                    result = true;
                    loop = false;
                }
            }
            catch
            {
                result = false;
                loop = false;
            }
        }

        return result;
        }
    }
}