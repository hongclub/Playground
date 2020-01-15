using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Playground
{
    public static class AsyncAwait
    {
        /// <summary>
		/// Method to excute async, then wait until it finish
		/// </summary>
        public static async Task AwaitMethod() 
        {
            await Task.Run(() => { LongTask(); });
            Console.WriteLine("New Thread 1st output ...");
        }

        /// <summary>
		/// Method to excute async without waiting
		/// </summary>
        public static void WithoutAwaitMethod()
        {
            Task.Run(() => { LongTask(); });    
            Console.WriteLine("New Thread 1st output ...");
        }

        public static void LongTask()
        {
            Thread.Sleep(20000);
        }
    }
}
