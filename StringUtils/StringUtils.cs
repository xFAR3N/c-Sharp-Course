using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace StringUtils
{
    internal static class StringUtils
    {
        public static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "String is empty";
            }
            string result = new string(input.Reverse().ToArray());
            return result;
        }
        public static int CountOccurences(string input, string fragment)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(fragment))
            {
                return 0;
            }
            int count = 0;
            int index = 0;

            while ((index = input.IndexOf(fragment, index)) != -1)
            {
                index += fragment.Length;
                count++;
            }
            return count;
        }
        public static string RemoveWhitespaces(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "String is empty";
            }
            string output = string.Concat(input.Where(s => !char.IsWhiteSpace(s)));
            return output;
        }
    }
}
