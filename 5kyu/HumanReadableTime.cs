using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace CodeWars._5kyu
{
    public class HumanReadableTime
    {
        public static string GetReadableTime(int seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            return string.Format("{0:d2}:{1:d2}:{2:d2}", (int)time.TotalHours, time.Minutes, time.Seconds);
        }
    }
}
