using System;
using System.Linq;
using System.Text.RegularExpressions;

// ref: https://www.tutorialsteacher.com/csharp/csharp-generics
namespace Playground
{
    // use <WW> instead of <T> to demostrate you can name T anything you want
    public class GenericClassExample<WW>
    {
        private WW genericVar;

        // constructor
        public GenericClassExample(WW value)
        {
            genericVar = value;
        }

        public WW genericMethod(WW parameter)
        {
            Console.WriteLine("ParameterType: {0}, val: {1}", typeof(WW).ToString(), parameter);
            Console.WriteLine("Variable Type: {0}, val: {1}", typeof(WW).ToString(), genericVar);

            return genericVar;
        }
    }
}
