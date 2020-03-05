/*The basic idea is, keep a hashmap which stores the characters in string as keys and their positions
 * as values.and keep two pointers which define the max substring.Move the right pointer to scan through
 the string , and meanwhile update the hashmap.If the character is already in the hashmap,then move the 
 left pointer to the right of the same character last found.Note the two pointers can only move forward*/

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuestions
{
    public class Longest_Substring_Without_Repeating_Characters
    {
        public int LengthOfLongestSubstring(String s)
        {
            if (s.length() == 0)
                return 0;
            HashMap<Character, Integer> map = new HashMap<Character, Integer>();
            int max = 0;
            for (int i = 0, j = 0; i < s.length(); ++i)
            {
                if (map.containsKey(s.charAt(i)))
                {
                    j = Math.max(j, map.get(s.charAt(i)) + 1);
                }
                map.put(s.charAt(i), i);
                max = Math.max(max, i - j + 1);
            }
            return max;
        }
    }
}

/*TIME COMPLEXITY : O(N)
 *this solution runs in O(N) time complexity where N is the size of the string.
 * SPACE COMPLEXITY: O(N)
 * This algorithm uses an extra space of size N
 */