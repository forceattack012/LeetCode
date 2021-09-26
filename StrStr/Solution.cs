using System;
using System.Collections.Generic;
using System.Text;

namespace StrStr
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            var x = haystack.IndexOf(needle);

            return x;
        }
    }
}
