using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars._6kyu
{
    public class CountingDuplicates
    {
        public static int DuplicateCount(string str)
            => str.ToLower().Distinct().Where(t => str.ToLower().Count(x => x - 32 == t || x == t) >= 2).Count();
    }
}
