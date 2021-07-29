using System;

namespace Text
{
    /// <summary>Public Str class.</summary>
    public class Str
    {
        /// <summary>Public CamelCase for Str class.</summary>
        public static int CamelCase(string s)
        {
            if (s == "")
            {
                return 0;
            }
            int count = 1;
            foreach (char word in s)
            {
                if (Char.IsUpper(word) == true)
                count +=1;
            }
            return count;
        }
    }
}
