using System;
using System.Collections.Generic;
using System.Text;

namespace ValidParentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            bool isValid = false;
            List<string> bucket = new List<string>()
            {
                "()",
                "{}",
                "[]"
            };

            do
            {
                if (s.Contains(bucket[0]))
                {
                    s = s.Replace(bucket[0], "");
                }
                else if(s.Contains(bucket[1]))
                {
                    s = s.Replace(bucket[1], "");
                }
                else if(s.Contains(bucket[2]))
                {
                    s = s.Replace(bucket[2], "");
                }
                else
                {
                    break;
                }

            } while (s.Length !=0);

            if(s == string.Empty)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
