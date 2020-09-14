/*Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].*/

using System;
using System.Collections.Generic;
using System.IO;

//brute force solution /time complexity = O(N*N)
public class SolutionOne
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0 + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        throw new Exception("not found");
    }
}
//using a dictionary /time complexity = O(N)
public class Solution1
{
    public int[] TwoSum1(int[] nums, int target)
    {
        Dictionary<int, int> hashTable = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (hashTable.ContainsKey(complement))
            {
                return new int[] { hashTable[complement], i };
            }
            else
            {
                hashTable[nums[i]] = i;
            }
        }
        throw new Exception("not found");
    }
}