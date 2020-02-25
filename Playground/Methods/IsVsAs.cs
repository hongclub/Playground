using System;
using System.Linq;
using System.Text.RegularExpressions;

// ref: https://www.geeksforgeeks.org/is-vs-as-operator-keyword-in-c-sharp/
namespace Playground
{
    public static class IsVsAs
    {
        public static void TestIs()
        {
            Car c = new Car();
            Truck t = new Truck();

            Console.WriteLine("C is a car: {0} ", c is Car);
            Console.WriteLine("C is a ship: {0}", c is Ship);
            Console.WriteLine("t is a car: {0}", c is Car);
       



        }
    }

    // base class
    public class Car { }

    public class Ship { } 


    // derived classes
    public class Truck : Car { }

    public class Suv : Car { } 


    

}
