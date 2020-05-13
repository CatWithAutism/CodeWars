using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._7kyu
{
    public class YouReASquare
    {
        public static bool IsSquare(int n)
          => Math.Sqrt(n) % 1 == 0;
    }
}
