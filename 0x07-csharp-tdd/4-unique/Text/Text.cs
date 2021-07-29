using System;
using System.Collections.Generic;
using System.Linq;

namespace Text
{
    /// <summary>Public Str class.</summary>
    public class Str
    {
        public static int UniqueChar(string s)
        {
            Dictionary<char,int>dic=new Dictionary<char,int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], 1);
                }
                else
                {
                    dic[s[i]] +=1;
                }
            }
            for (int i = 0; i <s.Length; i++)
            {
                if (dic[s[i]]==1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
