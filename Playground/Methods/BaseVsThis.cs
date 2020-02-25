using System;
using System.Linq;
using System.Text.RegularExpressions;

// ref: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/base
namespace Playground
{
    public static class BaseExample
    {
        public static void TestBase()
        {
            Employee e = new Employee();
            e.GetInfo();

        }
    }

    // base class
    public class Person
    {
        private string ssn = "111-11-1111";
        private string name = "Tommy";

        public virtual void GetInfo()
        {
            Console.WriteLine("Base Name: {0}", name);
            Console.WriteLine("Base SSN: {0}", ssn); 
        }
    }

    // derived class
    public class Employee : Person
    {
        private string id = "X104186";

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Derived Id: {0}", id);
        }
    }
}
