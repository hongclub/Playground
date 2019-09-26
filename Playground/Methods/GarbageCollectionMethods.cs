using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public static class GarbageCollectionMethods
    {
        /// <summary>
		/// Method to display max supported Heap generations
		/// </summary>
        public static void maxSupportedGenerations()
        {
            Console.WriteLine("the number of generations are: " + GC.MaxGeneration);
        }

        /// <summary>
		/// Method to get the generation # of a obj
		/// </summary>
        public static void getObjGeneration()
        {
            Demo obj = new Demo();
            Console.WriteLine("The generation number of object obj is: "
                                              + GC.GetGeneration(obj));
        }

        // <summary>
        /// Method to get current total allocated memory
        /// </summary>
        public static void getCurrentTotalAllocatedMemory()
        {
            Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));

            Demo obj = new Demo();

            Console.WriteLine("The generation number of object obj is: "
                                               + GC.GetGeneration(obj));

            Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
        }

        // <summary>
        /// Method to force a Garbage Collection
        /// </summary>
        public static void test()
        {
            GC.Collect(0);
            GC.Collect(0);
            GC.Collect(0);
            Console.WriteLine("Garbage Collection in Generation 0 is: "
                                              + GC.CollectionCount(0));
        }
    }
}
