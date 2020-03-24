using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Extentions
{
    public static class ExtentionMethods
    {
        public static string[] RemoveDelimiter(this string[] source)
        {
            return source.Select(s => s.Replace("/", "")).ToArray();
        }

        public static List<int> GetIntegerFromDelimiter(this string source)
        {
            //List<int> l = new List<int>();
            //try
            //{
            //    l = source.Split(',').Select(int.Parse).ToList();
            //}
            //catch { };

            //return l;


            //if (!string.IsNullOrEmpty(source))
            //    return source.Split(',').Select(int.Parse).ToList();
            //else
            //    return new List<int>();

            return string.IsNullOrEmpty(source?.Trim()) ? 
                new List<int>() : source.Split(',').Select(int.Parse).ToList();


        }

        public static Dictionary<string, int> GetDictionaryFromDelimiter(this string source)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            // var test = source.Split(',').ToList();
            try
            {
                d = source.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(part => part.Split('='))
                   .ToDictionary(split => split[0], split => int.Parse(split[1]));
            }
            catch { };

            return d;
        }

    }
}
