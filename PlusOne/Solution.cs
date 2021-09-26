using System;
using System.Collections.Generic;
using System.Text;

namespace PlusOne
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            string intString = "";
            List<int> list = new List<int>();
 
            for(int i = 0; i < digits.Length; i++)
            {
                intString += digits[i];
            }

            var temp = Decimal.Parse(intString) + 1;
            string strTemp = Convert.ToString(temp);

            for(int j = 0; j < strTemp.Length; j++)
            {
                list.Add(int.Parse(strTemp[j].ToString()));
            }

            return list.ToArray();
            
        }
    }
}
