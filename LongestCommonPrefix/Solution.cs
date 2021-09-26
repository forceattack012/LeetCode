using System;
using System.Collections.Generic;
using System.Text;

namespace LongestCommonPrefix
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int size = strs.Length;
            string prefix = strs[0];
            for (int i = 1; i < size; i++)
            {
                while(strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    if(prefix == string.Empty)
                    {
                        return "";
                    }
                }
            }
            return prefix;
        }
    }
}
