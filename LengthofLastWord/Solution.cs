using System;
using System.Collections.Generic;
using System.Text;

namespace LengthofLastWord
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            var splitWhiteSpace = s.Split(" ");
            string lastWord = "";

            for(int i = splitWhiteSpace.Length -1 ; i >= 0; i--)
            {
                if (!string.IsNullOrWhiteSpace(splitWhiteSpace[i]))
                {
                    lastWord = splitWhiteSpace[i];
                    break;
                }
            }

            return lastWord.Length;
        }

        public int LengthOfLastWordWithTrim(string s)
        {
            var splitWhiteSpace = s.TrimStart().TrimEnd().Split(" ");
            string lastWord = splitWhiteSpace[splitWhiteSpace.Length - 1];

            

            return lastWord.Length;
        }
    }
}
