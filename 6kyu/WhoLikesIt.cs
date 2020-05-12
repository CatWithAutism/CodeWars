using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._6kyu
{
    public class WhoLikesIt
    {
        public static string Likes(string[] name)
        {
            if (name == null || name.Length == 0)
                return "no one likes this";

            string likesThis = null;
            if (name.Length == 1)
                return $"{name[0]} likes this";
            else if (name.Length == 2)
                likesThis = $"{name[0]} and {name[1]}";
            else if (name.Length == 3)
                likesThis = $"{name[0]}, {name[1]} and {name[2]}";
            else if (name.Length > 3)
                likesThis = $"{name[0]}, {name[1]} and {name.Length - 2} others";

            return likesThis + " like this";
        }
    }
}
