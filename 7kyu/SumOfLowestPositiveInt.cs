using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._7kyu
{
    public class SumOfLowestPositiveInt
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
          => numbers.OrderBy(t => t).Take(2).Sum();
    }
}
