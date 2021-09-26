using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            bool isPalindrome = false;
            if (x < 0)
            {
                return isPalindrome;
            }

            int revese = 0;
            int temp = x;
            do
            {
                int mod = x % 10;
                x = x/10;
                revese = mod + (revese * 10);

            } while (x != 0);

            if(temp == revese)
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }

        public bool isPalindromeUseString(int x)
        {
            bool isPalindrome = false;
            if (x < 0)
            {
                return isPalindrome;
            }

            var strArrayX = x.ToString().ToCharArray();
            Array.Reverse(strArrayX);

            string str = new string(strArrayX);
            if (x.ToString().Equals(str))
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }
    }
}
