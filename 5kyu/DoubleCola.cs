using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CodeWars._5kyu
{
    public class DoubleCola
    {
        public static string WhoIsNext(string[] names, long queueIndex)
        {
            var countOf = new Queue<KeyValuePair<string, int>>(names.Select(t => new KeyValuePair<string, int>(t, 1)));

            long currentIndex = 0;
            while(true)
            {
                for(int i = 0; i < countOf.Count; i++)
                {
                    var name = countOf.Dequeue();
                    currentIndex += name.Value;

                    if(currentIndex >= queueIndex)
                    {
                        return name.Key;
                    }

                    countOf.Enqueue(new KeyValuePair<string, int>(name.Key, name.Value * 2));
                }
            }
        }
    }
}
