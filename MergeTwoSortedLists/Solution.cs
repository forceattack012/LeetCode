using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedLists
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode startMerge;
            if(l1 == null || l2 == null)
            {
                return l1 == null ? l2 : l1;
            }
            if(l1.val <= l2.val)
            {
                startMerge = l1;
                l1 = l1.next;
            }
            else
            {
                startMerge = l2;
                l2 = l2.next;
            }

            ListNode pMerge = startMerge;
            while(l1 != null && l2 != null)
            {
                if(l1.val <= l2.val)
                {
                    pMerge.next = l1;
                    pMerge = pMerge.next;
                    l1 = l1.next;
                    
                }
                else
                {
                    pMerge.next = l2;
                    pMerge = pMerge.next;
                    l2 = l2.next;
                }
            }

            if (l1 == null)
            {
                pMerge.next = l2;
            }
            else
            {
                pMerge.next = l1;
            }
            return startMerge;
        }
    }
}
