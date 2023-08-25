using System;
using System.Collections.Generic;
using System.Text;

namespace StringExtensions
{
    public static class EndsWithExtension
    {
        public static bool EndsWith(this string s, string[] patterns)
        {
            if (String.IsNullOrWhiteSpace(s))
            {
                throw new ArgumentNullException("s");
            }

            foreach (string pattern in patterns)
            {
                if (s.EndsWith(pattern))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
