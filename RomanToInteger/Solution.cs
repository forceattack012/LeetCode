using System;
using System.Collections.Generic;
using System.Text;

namespace RomanToInteger
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> romanDictionary = new Dictionary<char, int>()
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100 },
                {'D',500 },
                {'M',1000 },
            };

            int result = 0;

            for(int i = 0; i < s.Length; i++)
            {
                if (romanDictionary.ContainsKey(s[i]))
                {
                    if (i == s.Length - 1 || romanDictionary[s[i]] >= romanDictionary[s[i + 1]])
                    {
                        result += romanDictionary[s[i]];
                    }
                    else
                    {
                        result += romanDictionary[s[i + 1]] - romanDictionary[s[i]];
                        i++;
                    }
                }
            }

            return result;
        }
    }
}
