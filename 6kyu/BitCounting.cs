using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._6kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/526571aae218b8ee490006f4/train/csharp
    /// </summary>
    class BitCounting
    {
        public static int CountBits(int n)
            => Convert.ToString(n, 2).Count(t => t == '1');
    }
}
