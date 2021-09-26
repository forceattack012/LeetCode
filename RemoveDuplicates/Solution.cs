using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoveDuplicates
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            var temp = nums.Distinct().ToArray();

            for(int i = 0; i < temp.Length; i++)
            {
                nums[i] = temp[i];
            }
            return temp.Length;
        }
    }
}
