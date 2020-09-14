using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuestions
{
    class RomanToInteger
    {
        public int romanToInt(String s)
        {
            if (s == null || s.Length == 0)
            {
                return 0;
            }
            Map<Character, Integer> romanValues = new HashMap<>();
            romanValues.put('I', 1);
            romanValues.put('V', 5);
            romanValues.put('X', 10);
            romanValues.put('L', 50);
            romanValues.put('C', 100);
            romanValues.put('D', 500);
            romanValues.put('M', 1000);

            int Length = s.Length();
            int result = romanValues.get(s.charAt(Length - 1));

            for (int i = Length - 2; i >= 0; i--)
            {
                if (romanValues.get(s.charAt(i)) >= romanValues.get(s.charAt(i + 1)))
                {
                    result += romanValues.get(s.charAt(i));
                }
                else
                {
                    result -= romanValues.get(s.charAt(i));
                }
            }
            return result;
        }
    }
}
