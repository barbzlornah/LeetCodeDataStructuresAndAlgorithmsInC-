//each character is considered as the mid of a  palindrom string and the largest palindrome is checked
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuestions
{
    public class LongestPalindromicSubstring
    {
        private int lo, maxLen;

        public String LongestPalindrom(String s)
        {
            int len = s.Length();
            if (len < 2) return s;

            for(int i = 0; i < len-1; i++)
            {
                //assume odd length try to extend palindrome as possible
                extendPalindrome(s, i, i);
                //assume even length
                extendPalindrome(s, i, i + 1);
            }
            return s.Substring(lo, lo + maxLen);

        }
        private void extendPalindrome(String s, int j, int k)
        {
            while(j >= 0 && k< s.Length() && s.charAt(j) == s.charAt(k))
            {
                j--;
                k++;
            }
            if(maxLen < k-j-1)
            {
                lo = j + 1;
                maxLen = k - j - 1;
            }
        }
    }
}
