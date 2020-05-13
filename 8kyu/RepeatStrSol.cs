using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._8kyu
{
    public class RepeatStrSol
    {
        public static string RepeatStr(int n, string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(s);
            }
            return sb.ToString();
        }
    }
}
