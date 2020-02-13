using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ref: https://www.tutorialspoint.com/what-is-the-difference-between-virtual-and-abstract-functions-in-chash
namespace Playground.Methods
{
    public abstract class Vehicle
    {
        public abstract void Driving();
    }

    public class Car : Vehicle
    {
        public override void Driving()
        {
            Console.WriteLine("Driving a car ... ");
        }
    }

    public class Bus : Vehicle
    {
        public override void Driving()
        {
            Console.WriteLine("Driving a bus ...");
        }
    }
}
