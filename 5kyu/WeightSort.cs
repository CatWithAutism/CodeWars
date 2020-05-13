using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._5kyu
{
    public class WeightSort
    {
        public static string OrderWeight(string strng)
            => string.Join(' ', strng.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(t => new KeyValuePair<long, long>(long.Parse(t), t.Sum(i => long.Parse(i.ToString()))))
            .OrderBy(t => t.Value)
            .ThenBy(t => t.Key.ToString())
            .Select(t => t.Key));
    }
}
