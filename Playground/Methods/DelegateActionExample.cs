using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Playground
{
    public static class DelegateActionExample
    {

        public static void TestSimpleVersion()
        {
            Action<int, int, int> display = (x, y, z) => Console.WriteLine("x: {0}, y: {1}, z: {2}", x, y, z);    // Action<> similar to Func<>, except there is not return output, just void
            display(100, 200, 300);
            Console.ReadLine();
        }
    }
}
