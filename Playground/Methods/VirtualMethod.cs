using System;
using System.Linq;
using System.Text.RegularExpressions;

// ref: https://www.tutorialspoint.com/what-is-the-difference-between-virtual-and-abstract-functions-in-chash
namespace Playground
{
    public class Shape
    {
        protected int width, height;

        public Shape(int a, int b)
        {
            width = a;
            height = b;
        }

        public virtual int area()
        {
            var areaResult = 0;
            Console.WriteLine("Base Shape area: {0}", areaResult);
            return areaResult;
        }
    }

    public class Rectange: Shape
    {
        public Rectange(int a, int b) : base(a, b)
        { 
            // using the base
        }

        public override int area()
        {
            var areaResult = width * height;
            Console.WriteLine("Inhereited Rectangle area: {0}", areaResult);
            return areaResult;
        }
    }
}
