using System;
using System.Linq;
using System.Text.RegularExpressions;

// ref: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/base
namespace Playground
{
    public static class ThisExample
    {
        public static void TestThis()
        {
            Employee2 e = new Employee2("X104186", "something");
            e.DoSomething();
        }
    }

    // base class
   
    public class Employee2 
    {
        private string somthinggggggggggggg;

        public Employee2(string id, string somthinggggggggggggg)
        {
            this.somthinggggggggggggg = somthinggggggggggggg;
        }

        public void DoSomething()
        {
            Console.WriteLine(this.somthinggggggggggggg);
        }
    }
}
