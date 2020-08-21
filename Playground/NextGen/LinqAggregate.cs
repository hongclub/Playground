using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.NextGen
{
    public static class LinqAggregate
    {
        /// <summary>
        /// Method to use Linq Aggregate()
        /// behavior: if the card has value, it should return the CardNumber after ?
        /// </summary>
        public static void Test()
        {
            string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };

            // Determine whether any string in the array is longer than "banana".
            string longestName =
                fruits.Aggregate("banana",
                                (longest, next) =>
                                    next.Length > longest.Length ? next : longest,
                                // Return the final result as an upper case string.
                                fruit => fruit.ToUpper());

            Console.WriteLine(
                "The fruit with the longest name is {0}.",
                longestName);
        }


       
      
    }


}
