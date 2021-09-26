using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoveElement
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            var expected = nums.Where(r => r != val).ToArray();
            
            for(int i = 0; i < expected.Length; i++)
            {
                nums[i] = expected[i];
            }

            return expected.Length;
        }
    }
}
