using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._8kyu
{
    public class SumOfPositiveNums
    {
        public static int PositiveSum(int[] arr)
            => arr.Where(t => t > 0).Sum();
    }
}
