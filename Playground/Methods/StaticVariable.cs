using System;
using System.Linq;
using System.Text.RegularExpressions;

// ref: https://www.geeksforgeeks.org/static-keyword-in-c-sharp/
namespace Playground
{
    public  class StaticVariable
    {
        public static string staticV = "Original Static variable";
        public string nonStaticV = "Original nonStatus variable";


        public static void displayStatic()
        {
            Console.WriteLine(staticV);
        }
    }
}
