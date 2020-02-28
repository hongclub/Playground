using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ref: https://www.c-sharpcorner.com/UploadFile/rohatash/difference-between-object-and-dynamic-keyword-in-C-Sharp/
namespace Playground.Methods
{
    static class ObjectVsDynamic
    {
        public static void TestObject()
        {
            object o = "Test Object";
            //string s = o; // you cannot do that
            string s = (string)o; 
            int i = (int)o;         // it still causes problems
            Console.WriteLine(o);
        }

        public static void TestDynamic()
        {
            dynamic o = "Test Dynamic";
            string s = o;
            int i = o;              // it still causes problems
            Console.WriteLine(o);
        }
    }
}
