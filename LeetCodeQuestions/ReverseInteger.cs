/* PROBLEM:
 Given a 32-bit signed integer, reverse digits of an integer.

Example 1:

Input: 123
Output: 321
Example 2:

Input: -123
Output: -321
Example 3:

Input: 120
Output: 21
Note:
Assume we are dealing with an environment which could only store integers within the 32-bit signed 
integer range: [−231,  231 − 1]. For the purpose of this problem, assume that your function returns 
0 when the reversed integer overflows.
 */

/* SOLUTION:
 Use a long to detect overflow simply check if the long value has passed the allowed range of a 32 bit 
 int. The heart of the problem is in the line res = (x % 10) + (res * 10) which builds the reversed
 value digit by digit. This line of code pulls the least significant digit from x and shifts our 
 current accumulated res one digit over finally adding the results together. the x is then divided by 
 10 to get rid of the least significant digit since we have already accommodated this digit in our 
 reversed integer.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuestions
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            long res = 0;
            while(x != 0)
            {
                res = (x % 10) + (res * 10);
                if (res > Int32.MaxValue || res < Int32.MinValue) return 0;
                x /= 10;
            }
            return (int)res;
        }
    }
}
