using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace StringExtensions
{
    public static class ContainsExtension
    {
        public static bool Contains(this string s, string[] patterns, ContainsRule rule = ContainsRule.Any)
        {
            if (String.IsNullOrWhiteSpace(s))
            {
                throw new ArgumentNullException("s");
            }

            bool contains = false;

            foreach (string pattern in patterns) 
            {
                if (s.Contains(pattern))
                {
                    contains = true;

                    if (rule == ContainsRule.Any)
                    {
                        return true;
                    }
                }
                else
                {
                    contains = false;

                    if (rule == ContainsRule.All)
                    {
                        return false;
                    }
                }
            }

            return contains;
        }
    }

    public enum ContainsRule
    {
        Any, All
    }
}
