using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars._7kyu
{
    public class VowelCount
    {
        private static string _vowels = "aeiou";
        public static int GetVowelCount(string str)
            => str.Count(t => _vowels.Contains(t));
    }
}
