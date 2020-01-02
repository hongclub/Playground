using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public static class LinqMethods
    {

        // default values for each type
        // /////////////////////////////////////////////////////////////////////////////////////////////////////
        // Any reference type ................................ null
        // Any built-in integral numeric type ................ 0 (zero)
        // bool .............................................. false
        // GUID .............................................. Guid.Empty (00000000-0000-0000-0000-000000000000)
        // /////////////////////////////////////////////////////////////////////////////////////////////////////



        /// <summary>
        /// Method to use SingleOrDefault()
        /// SingleOrDefault behavior: if the .where result returns more than 1 item, it will throw exception
        /// SingleOrDefault behavior: if the .where has no result, then it will return default value of GUID (GUID.Empty)
        /// </summary>
        public static void SingleOrDefault()
        {
            Guid[] arr = new Guid[2];
            arr[0] = new Guid("0c0bf5b5-f5c7-4e1d-a682-86107eba38f6");
            arr[1] = new Guid("0c0bf5b5-f5c7-4e1d-a682-86107eba38f6"); 

            var result = arr.Where( x => x == new Guid("0c0bf5b5-f5c7-4e1d-a682-86107eba38f6") ).SingleOrDefault(); // throw error: cannot have more than one as result
        }


        /// <summary>
        /// Method to use FirstOrDefault()
        /// FirstOrDefault behavior: if the .where result returns more than 1 item, it will throw exception
        /// </summary>
        public static void FirstOrDefault()
        {
            //Guid[] arr = new Guid[2];
            //arr[0] = new Guid("0c0bf5b5-f5c7-4e1d-a682-86107eba38f4");
            //arr[1] = new Guid("0c0bf5b5-f5c7-4e1d-a682-86107eba38f4");

            //var result = arr.Where(x => x == new Guid("0c0bf5b5-f5c7-4e1d-a682-86107eba38f6")).FirstOrDefault();


            Card card = new Card();
            Card[] arr = new Card[2];
            arr[0] = new Card() { Id = "1", CardHolderFirstName = null, CardHolderLastName = null, CardNumber = "1234" };
            arr[1] = new Card() { Id = "2" };

            //card = arr.FirstOrDefault( x => x.Id == "1");

            //string CardHolderName = card == null ? string.Empty : $"{card.CardHolderFirstName?.Trim()} {card.CardHolderLastName?.Trim()}";
            //string CardNumber = card?.CardNumber;


            for (var i = 1; i <= arr.Length; i++)
            {
                Console.WriteLine("new:" + (i));
            }
            Console.WriteLine("");

            for (var i = 1; i < arr.Length; i++)
            {
                Console.WriteLine("fix:" + (i+1));
            }
            Console.WriteLine("");

            for (var i = 0; i <= arr.Length; i++)
            {
                Console.WriteLine("old:" + i);
            }
            Console.WriteLine("");

            for (var i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("fix:" + i);
            }
            Console.WriteLine("");


            var counter = new[] { 1 };
            foreach (var c in arr)
            {
               
               Console.WriteLine("cde:" + counter[0]++);
   

            }
            Console.WriteLine("");
 

    }


        /// <summary>
        /// Method to use FirstOrDefault()
        /// First behavior: if the .where result returns not item, it will throw exception
        /// </summary>
        public static void First()
        {
            Guid[] arr = new Guid[2];
            arr[0] = new Guid("0c0bf5b5-f5c7-4e1d-a682-86107eba38f5");
            arr[1] = new Guid("0c0bf5b5-f5c7-4e1d-a682-86107eba38f5");

            var result = arr.Where(x => x == new Guid("0c0bf5b5-f5c7-4e1d-a682-86107eba38f6")).First(); // throw error: must have at least one result
        }
    }
}
