using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars._5kyu
{
    public class NotVerySecure
    {
        public static bool Alphanumeric(string str)
            => Regex.IsMatch(str, @"^[a-zA-Z\d]*$", RegexOptions.Compiled);
    }
}
