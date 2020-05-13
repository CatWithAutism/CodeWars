using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._4kyu
{
    public class NextBiggerNumberSol
    {
        public static long NextBiggerNumber(long n)
        {
            string strNumber = n.ToString();
            int rightMinIndex = -1;
            for(int i = strNumber.Length - 2; i >= 0; i--)
            {
                if (strNumber[i + 1] > strNumber[i])
                {
                    rightMinIndex = i;
                    break;
                }
            }

            if (rightMinIndex == -1)
                return -1;

            string leftPart = strNumber.Substring(0, rightMinIndex);
            string rightPart = strNumber.Substring(rightMinIndex + 1);
            string rightValue = strNumber.Substring(rightMinIndex, 1);
            int rightValueInt = int.Parse(rightValue);

            int largerDigit = rightPart.Select(t => int.Parse(t.ToString())).OrderBy(t => t)
                .FirstOrDefault(t => t > rightValueInt);

            rightPart = string.Concat((rightPart.Remove(rightPart.LastIndexOf(largerDigit.ToString()), 1) + rightValue)
                .OrderBy(t => t));

            return long.Parse(leftPart + largerDigit + rightPart);
        }
    }
}
