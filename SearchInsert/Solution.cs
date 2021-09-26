using System;
using System.Collections.Generic;
using System.Text;

namespace SearchInsert
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int index = 0;
            int size = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                if(target >= nums[i])
                {
                    if(target == nums[i])
                    {
                        index = i;
                        return index;
                    }
                    if(i != size-1) 
                    {
                        if(target > nums[i] && target < nums[i + 1])
                        {
                            index = i + 1;

                            return index;
                        }
                    }
                    else
                    {
                        index = i + 1;

                        return index;
                    }
                }
            }

            return index;
        }
    }
}
