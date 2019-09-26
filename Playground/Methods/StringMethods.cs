using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace Playground
{
    public static class StringMethods
    {
        /// <summary>
		/// Method to mask credit card before last 4 characters
		/// </summary>
        public static string maskbeforeLast4characaters(string input)
        {
            var result = string.Empty;
            result = string.IsNullOrEmpty(input) ? null : Regex.Replace(input, @"(\d{12})", string.Concat(Enumerable.Repeat("X", 12))) ;
            result = string.Format("{0}{1}", string.Concat(Enumerable.Repeat("X", 12)), input.Substring(input.Length - 4, 4));
            result = input.Substring(input.Length - 4, 4).PadLeft(16, 'X');
            return result;
        }
    }
}
