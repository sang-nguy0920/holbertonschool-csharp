using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMath
{
    /// <summary>Public Operations class.</summary>
    public class Operations
    {
        /// <summary>Public constructor for Operations class.</summary>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
            {
                return 0;
            }
            return (nums.Max());       
        }
    }
}
