using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] indexOfNumbers = new int[nums.Length];
 
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i+1; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == target)
                    {
                        indexOfNumbers = new int[] { i,j };
                        break;
                    }
                }
            }

            return indexOfNumbers;
        }

        public int[] TwoSumUseDictionanry(int[] nums, int target)
        {

            List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                list.Add(new KeyValuePair<int,int>(nums[i], i));
            }

            for(int j = 0; j < nums.Length; j++)
            {
                int findNumber = target - nums[j];

                foreach(KeyValuePair<int,int> kvp in list)
                {
                    if(kvp.Key == findNumber && kvp.Value != j)
                    {
                        return new int[] { j, kvp.Value };
                    }
                }
            }
            return new int[] { };
        }
    }
}
