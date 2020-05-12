using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._6kyu
{
    public class MultiplesOf3or5
    {
        public static int Solution(int value)
            => Enumerable.Range(0, value).Where(t => t % 3 == 0 || t % 5 == 0).Sum();
    }
}
