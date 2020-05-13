using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._6kyu
{
    public class RecSumOfDigits
    {
        public static int DigitalRoot(long n)
        {
            while (n > 9) n = n.ToString().Sum(t => int.Parse(t.ToString()));
            return (int)n;
        }
    }
}
