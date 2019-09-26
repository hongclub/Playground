using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public static class Test
    {
        public static IEnumerable<T> IfNullThenEmpty<T>(this IEnumerable<T> data)
        {
            return data == null ? new T[0] : data.AsEnumerable();
        }
    }
}
