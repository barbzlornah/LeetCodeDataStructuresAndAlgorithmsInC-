/*SOLUTION
 *Since the digits are stored in reverse ,we can solve this problem by traversing  both the lists and
 * adding its value(just like adding any two numbers manually).If the sum exceeds 10,store only the last 
 * digit and carry to the next  sum and repeat the process.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace LeetCodeQuestions
{
   public class AddingTwoNumbers
    {
        public  ListNode addTwoNumbers(ListNode L1, ListNode L2)
        {
            ListNode curr = 0, head = null;
            int sum = 0, carry = 0;

            //go through all the nodes
            while(L1 != null || L2 != null)
            {
                sum = carry;
                if(L1 != null)
                {
                    sum += L1.val;
                    L1 = L1.next;
                }
                if(L2 != null)
                {
                    sum += L2.val;
                    L2 = L2.next;
                }
                //add the numbers and store only the last digit
                ListNode n = new ListNode(sum % 10);
                //add to the resut list
                if(curr = null)
                {
                    curr = n;
                    head = n;
                }
                else
                {
                    curr.next = n;
                    curr = curr.next;
                }
                //calculate the carry
                carry = sum / 10;
            }
            //no more list elements, handle the carry value if available
            if(carry == 1)
            {
                curr.next = new ListNode(1);
            }
            //handle empty list scenarios
            return head != null ? head : new ListNode(0);
        }

    }
}
/*TIME COMPLEXITY O(N)
 * O(N1) + O(N2) = O(N) where N1 and N2 represent the lengths of L1 and L2
 * SPACE COMPLEXITY
 * O(1) + O(N) = O(N).O(1) for the variables and  O(N) for the result array.
 */
