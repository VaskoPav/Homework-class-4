using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task01.Entiteis
{
    public static class StringHelper
    {
        public static string FirstLetter(this string str, int Words)
        {
            if (Words < 1)
                throw new ArgumentException("Error");

            if (str.Length == 0)
                return "";

            string[] words = str.Split(' ');

            if (words.Length < Words)
                return str;

            List<string> substring = words.Take(Words).ToList();

            string result = string.Join(" ", substring);

            return result + "...";
        }

        public static string GetLast(this string baseS, int length)
        {
            if (length >= baseS.Length)
                return baseS;
            return baseS.Substring(baseS.Length -length);
        }
        
        
        public static bool IsGreaterThan(this int i, int value)
        {
                return i > value;
        }
        

    }
}

