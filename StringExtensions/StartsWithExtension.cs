using System;
using System.Collections.Generic;
using System.Text;

namespace StringExtensions
{
    public static class StartsWithExtension
    {
        public static bool StartsWith(this string s, string[] patterns)
        {
            if (String.IsNullOrWhiteSpace(s))
            {
                throw new ArgumentNullException("s");
            }

            foreach (string pattern in patterns)
            {
                if (s.StartsWith(pattern))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
