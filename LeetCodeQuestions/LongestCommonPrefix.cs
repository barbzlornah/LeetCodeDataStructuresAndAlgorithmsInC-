/* Problem : Write a function to find the longest common prefix string amongst an array of strings
 * If there is no common prefix, return an empty string "".

Example 1:

Input: ["flower","flow","flight"]
Output: "fl"
 */
// Solution: Sort the array first and then you can compare the first and the last elements in the sorted array

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuestions
{
    public class LongestCommonPrefix
    {
        public String LongestPrefix(String[] strs)
        {
            StringBuilder result = new StringBuilder();

            if(strs != null && strs.Length > 0)
            {
                Array.Sort(strs);

                char[] a = strs[0].ToCharArray();
                char[] b = strs[strs.Length - 1].ToCharArray();

                for (int i = 0; i < a.Length; i++)
                {
                    if(b.Length > i && b[i] == a[i])
                    {
                        result.Append(b[i]);
                    }
                    else
                    {
                        return result.ToString();
                    }
                }
            }
            return result.ToString();
        }
    }
}
