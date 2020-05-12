using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._7kyu
{
    public class DescendingOrderSol
    {
        public static int DescendingOrder(int num)
            => Convert.ToInt32(string.Concat(num.ToString().OrderByDescending(t => t)));
    }
}
