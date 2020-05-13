using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._5kyu
{
    public class Parentheses
    {
        public static bool ValidParentheses(string input)
        {
            int opened = 0;
            foreach(char ch in input)
            {
                if (ch == '(')
                {
                    opened++;
                }
                else if(ch == ')')
                {
                    opened--;
                    if (opened < 0)
                        return false;
                }
            }

            return opened == 0;
        }
    }
}
