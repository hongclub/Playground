using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Playground
{
    public delegate int whateverDelegateOperation(int i, int j);        // this declaration of delegate is not necessary, C# 3.0 Func<> should take care of it 

    public static class DelegateExample
    {
        public static int Sum(int x, int y)
        {
            return x + y; 
        }

        public static void Test()
        {
            whateverDelegateOperation add = Sum;    // whateverDelegateOperation is a delegate type
            int result = add(1, 2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
