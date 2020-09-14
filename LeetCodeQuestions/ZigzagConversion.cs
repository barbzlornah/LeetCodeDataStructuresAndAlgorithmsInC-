using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuestions
{
    public class ZigzagConversion
    {
        public string Convert(string s, int numRows)
        {
            string[] str = new string[numRows];
            for (int i = 0; i < str.Length; i++) str[i] = "";
            for (int i = 0; i < s.Length;)
            {
                for (int m = 0; m < numRows && i < s.Length; m++)
                {
                    str[m] += s[i++];
                }
                for (int n = numRows - 2; n > 0 && i < s.Length; n--)
                {
                    str[n] += s[i++];
                }
            }
            string result = "";
            foreach (string ss in str) result += ss;
            return result;
        }
    }
}
