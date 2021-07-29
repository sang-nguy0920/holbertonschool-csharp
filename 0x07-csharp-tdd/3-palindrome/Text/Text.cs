using System;
using System.Linq;
using System.Collections.Generic;

namespace Text
{
    /// <summary>Public Str class.</summary>
    public class Str
    {
        /// <summary>Public IsPalindrome for Str class.</summary>
        public static bool IsPalindrome(string s)
        {
            List<char> pali = new List<char>();
            foreach (char p in s)
            {
                if (!Char.IsPunctuation(p) && !Char.IsWhiteSpace(p))
                {
                    pali.Add(Char.ToLower(p));
                }
            }
            if (pali.Count == 0)
            {
                return true;
            }
            List<char> res = new List<char>(pali);
            res.Reverse();
            return (pali.SequenceEqual(res));   
        }
    }
}
