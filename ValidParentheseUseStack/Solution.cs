using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheseUseStack
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for(int i =0; i < s.Length; i++)
            {
                if(s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if(stack.Count == 0)
                    {
                        return false;
                    }
                    var ch = stack.Peek();
                    if (!match(ch , s[i]))
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }
            return stack.Count == 0;
        }

        public bool match(char a, char b)
        {
            if(a == '(' && b == ')')
            {
                return true;
            }
            else if(a == '{' && b == '}')
            {
                return true;
            }
            else if(a == '[' && b == ']')
            {
                return true;
            }
            return false;
        }
    }
}
