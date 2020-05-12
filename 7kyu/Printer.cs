using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._7kyu
{
    public class Printer
    {
        public static string PrinterError(string s)
            => $"{s.Where(t => t > 'm').Count()}/{s.Length}";
    }
}
