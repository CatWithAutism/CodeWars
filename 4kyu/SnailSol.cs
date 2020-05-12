using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CodeWars._4kyu
{
    public class SnailSol
    {
        public static int[] Snail(int[][] array)
        {
            if (array.FirstOrDefault().Length == 0)
                return new int[0];

            List<int> snailSort = new List<int>();

            int itemsLeft = array.Length * array.Length;
            int currentOffset = 0;
            int length = array.Length;
            while (itemsLeft != 0)
            {
                if(itemsLeft == 1)
                {
                    int center = array.Length / 2;
                    snailSort.Add(array[center][center]);
                    return snailSort.ToArray();
                }

                for(int i = currentOffset; i < length - currentOffset; i++)
                {
                    snailSort.Add(array[currentOffset][i]);
                    itemsLeft--;
                }

                for (int i = currentOffset + 1; i < length - currentOffset; i++)
                {
                    snailSort.Add(array[i][length - 1 - currentOffset]);
                    itemsLeft--;
                }

                for (int i = length - 2 - currentOffset; i > currentOffset - 1; i--)
                {
                    snailSort.Add(array[length - 1 - currentOffset][i]);
                    itemsLeft--;
                }

                for (int i = length - 2 - currentOffset; i > currentOffset; i--)
                {
                    snailSort.Add(array[i][currentOffset]);
                    itemsLeft--;
                }

                currentOffset++;
            }

            return snailSort.ToArray();
        }
    }
}
