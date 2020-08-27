using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._6kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/523f5d21c841566fde000009/train/csharp
    /// </summary>
    class ArrayDifference
    {
        public static int[] ArrayDiff(int[] a, int[] b)
            => a.Where(t => !b.Contains(t)).ToArray();
    }
}
