using System;
namespace AdventOfCode2023.Common
{
	public static class StringExtensions
	{
        /// <summary>
        /// Replace the first instance of a string inside another string eg "helloqwerty".Replace("e","X") => "hXlloquerty"
        /// </summary>
        /// <param name="text"></param>
        /// <param name="search"></param>
        /// <param name="replace"></param>
        /// <returns></returns>
        public static string ReplaceFirst(this string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }


        /// <summary>
        /// Reverse a string - eg "abc" becomes "cba"
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Reverse( this string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

