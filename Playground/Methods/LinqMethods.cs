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


            Card result = new Card();
            Card[] arr = new Card[2];
            arr[0] = new Card() { Id = "1" };
            arr[1] = new Card() { Id = "2" };

            result = arr.FirstOrDefault( x => x.Id == "3");
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
