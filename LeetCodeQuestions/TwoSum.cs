using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuestions
{
    class TwoSum
    {
        public int[] Twosum(int [] nums,int target)
        {
            //array to return theresult
            int[] arr= new int[2];

            //map for number and index pair
            Map<Integer, Integer> map = new HashMap<Integer, Integer>();

            //iterate through the array
            for(int i = 0; i < nums.Length; i++)
            {
                /*check if the map has an element which is equal to the difference 
                 between the target and the cureent element*/
                Integer val = map.get(target - nums[i]);
                if(val == null)
                {
                    //if no match found, add the current number and index to map
                    map.put(nums[i], i);
                }
                else
                {
                    //match found,update the index values
                    arr[0] = val;
                    arr[1] = i;
                }
            }
            return arr;
        }
    }
}
