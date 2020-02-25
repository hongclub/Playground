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

            Console.WriteLine("Check if C is a car: {0} ", c is Car);
            Console.WriteLine("Check if C is a ship: {0}", c is Ship);
            Console.WriteLine("Check if t is a car: {0}", c is Car);
        }

        public static void TestAs()
        {
            Car c = new Car();
            Truck t = new Truck();
            Ship s = new Ship();

            Console.WriteLine("Convert C to car: {0} ", c as Car);
            // Console.WriteLine("Convert C is a ship: {0}", c as Ship); // fail in complier time
            Console.WriteLine("Covert t to car: {0}", t as Car);
            Console.WriteLine("Convert c to truck: {0}", c as Truck);
        }
    }

    // base class
    public class Car { }

    public class Ship { } 


    // derived classes
    public class Truck : Car { }

    public class Suv : Car { } 


    

}
