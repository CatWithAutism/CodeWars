using System.Collections;
using System.Linq;

namespace CodeWars._8kyu
{
    class GetN_1Array
    {
        public static int[] Arr(int N)
            => Enumerable.Range(0, N).ToArray();
    }
}
