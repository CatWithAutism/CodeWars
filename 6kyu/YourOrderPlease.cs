using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars._6kyu
{
    public class YourOrderPlease
    {
        public static string Order(string words)
            => string.Join(' ', words.Split(' ', System.StringSplitOptions.RemoveEmptyEntries)
            .Select(t => new KeyValuePair<int, string>(int.Parse(Regex.Match(t, @"\d", RegexOptions.Compiled).Value), t))
            .OrderBy(t => t.Key)
            .Select(t => t.Value));
    }
}
