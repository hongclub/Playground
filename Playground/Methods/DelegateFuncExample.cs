﻿using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

// ref: https://www.tutorialsteacher.com/csharp/csharp-func-delegate
namespace Playground
{
    // Similar to DelegateExample.cs
    // x public delegate int whateverDelegateOperation(int i, int j);        // this declaration of delegate is not necessary, C# 3.0 Func<> should take care of it 

    public static class DelegateFuncExample
    {
        public static int Sum(int x, int y)
        {
            return x + y; 
        }

        public static void Test()
        {
            Func<int, int,     int> add = Sum;    // Func<>: first two ints are input, last one is result output
            int result = add(1, 2);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void TestSimpleVersion()
        {
            Func<int, int, int> add = (x , y) => x + y ;    // inline Func: this simple version not even need a Sum method
            int result = add(1, 2);
            Console.WriteLine(result);
            Console.ReadLine();
        }


    }
}
