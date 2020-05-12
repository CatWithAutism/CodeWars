using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._6kyu
{
    public class ReverseAndCombineSol
    {
        public static string ReverseAndCombineText(string text)
        {
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (words.Length > 1)
            {
                List<string> newWords = new List<string>();
                for (int i = 0; i < (words.Length % 2 == 0 ? words.Length : words.Length - 1); i += 2)
                {
                    newWords.Add(string.Concat(words[i].Reverse()) + string.Concat(words[i + 1].Reverse()));
                }

                if(words.Length % 2 != 0)
                {
                    newWords.Add(string.Concat(words[words.Length - 1].Reverse()));
                }

                words = newWords.ToArray();
            }

            return string.Join(" ", words);
        }
    }
}
