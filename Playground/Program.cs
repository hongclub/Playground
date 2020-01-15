using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Diagnostics;
using Playground.Methods;
using Playground.Models;




/* /// Test : MaskbeforeLast4characaters
/////////////////////////////////////////////////////////////////////////////////////////////////////////
/// <summary>
/// class: StringMethods.cs
/// Test : MaskbeforeLast4characaters
/// </summary>
namespace Playground
{
    class testMaskbeforeLast4characaters
    {
        /// <summary>
		/// Method to mask credit card before last 4 characters
		/// </summary>
        static void Main(string[] args)
        {
            // Arrange
            var cards = new List<Card>()
            {
                new Card(){ CardNumber = "23423sdfsfsdf42423432424", CardToken = "T1111" },
                new Card() { CardNumber = "2222", CardToken = "T2222" },
                new Card() { CardNumber = "3333", CardToken = "T3333" }

            };
            string c = cards.FirstOrDefault(x => x.CardToken == "T1111")?.CardNumber;

            // Act
            try
            {
                //c = string.Empty;
                //c = null;
                // c = string.IsNullOrEmpty(c) ? null : Regex.Replace(c, @"(\d{12})", string.Concat(Enumerable.Repeat("X", 12))) ;
                // c = string.Format("{0}{1}", string.Concat(Enumerable.Repeat("X", 12)), c.Substring(c.Length - 4, 4));
                // c = c.Substring(c.Length - 4, 4).PadLeft(16, 'X');
                c = StringMethods.maskbeforeLast4characaters(c);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // 
            Console.WriteLine("card number: " + c);
            Console.ReadLine();
        }    
    }

    public class Card
    {
        public string CardNumber { get; set; }
        public string CardToken { get; set; }
     }

}

/////////////////////////////////////////////////////////////////////////////////////////////////////////    
*/


///// Test : GarbageCollectionMethods.cs
///////////////////////////////////////////////////////////////////////////////////////////////////////////
///// <summary>
///// 
///// class: GarbageCollectionMethods.cs
///// Test : GarbageCollectionMethods.cs
///// </summary>
//namespace Playground
//{
//    public class Demo
//    {
//        public static void Main(string[] args)
//        {
//            // Acts
//            // GarbageCollectionMethods.maxSupportedGenerations();
//            // GarbageCollectionMethods.getObjGeneration();
//            // GarbageCollectionMethods.getCurrentTotalAllocatedMemory();
//            GarbageCollectionMethods.test();

//            Console.ReadLine();
//        }

//    }
//}

///////////////////////////////////////////////////////////////////////////////////////////////////////////  
///

///// Test : IEnumerableExample.cs
///////////////////////////////////////////////////////////////////////////////////////////////////////////
///// <summary>
///// 
///// class: IEnumerableExample.cs
///// Test : IEnumerableExample.cs
///// </summary>
//namespace Playground
//{
//    public class Demo
//    {
//        public static void Main(string[] args)
//        {
//            // Acts
//            // GarbageCollectionMethods.maxSupportedGenerations();
//            // GarbageCollectionMethods.getObjGeneration();
//            // GarbageCollectionMethods.getCurrentTotalAllocatedMemory();
//            IEnumerableExample.test();

//            Console.ReadLine();
//        }

//    }
//}

///////////////////////////////////////////////////////////////////////////////////////////////////////////    


//// Test : IEnumerableExample.cs
///////////////////////////////////////////////////////////////////////////////////////////////////////////
///// <summary>
///// 
///// class: LinqMethods.cs
///// Test : LinqMethods.cs
///// </summary>
//namespace Playground
//{
//    public class Demo
//    {
//        public static void Main(string[] args)
//        {
//            // Acts
//            // LinqMethods.SingleOrDefault();
//            LinqMethods.FirstOrDefault();
//            // LinqMethods.First();

//            Console.ReadLine();
//        }

//    }
//}

///////////////////////////////////////////////////////////////////////////////////////////////////////// 


///////////////////////////////////////////////////////////////////////////////////////////////////////////
///// <summary>
///// 
///// class: NullOperators.cs.cs
///// Test : NullOperators.cs.cs
///// </summary>
//namespace Playground
//{
//    public class Demo
//    {
//        public static void Main(string[] args)
//        {
//            //NullOperators.singleQuestionMarkwithValue();
//            NullOperators.singleQuestionMarkwithoutValue();

//            Console.ReadLine();
//        }

//    }

//}

///////////////////////////////////////////////////////////////////////////////////////////////////////////// 

//// Test : LazyLoading.cs
///////////////////////////////////////////////////////////////////////////////////////////////////////////
///// <summary>
///// 
///// class: LazyLoadingExample.cs
///// Test : LazyLoadingExample.cs
///// </summary>
//namespace Playground
//{
//    public class Demo
//    {
//        public static void Main(string[] args)
//        {
//            LazyLoadingExample o = new LazyLoadingExample(); // order object not loaded
//            Console.WriteLine(o.CustomerName);
//            foreach (Order o1 in o.Orders) // Load order object only at this moment
//            {
//                Console.WriteLine(o1.OrderNumber);
//            }
//            Console.ReadLine();
//        }

//    }
//}

/////////////////////////////////////////////////////////////////////////////////////////////////////// 

///////////////////////////////////////////////////////////////////////////////////////////////////////////// 

// Test : AsyncAwait.cs
///////////////////////////////////////////////////////////////////////////////////////////////////////
// <summary>
/// 
/// class: await a thread
/// </summary>
namespace Playground
{
    public class Demo
{
    public static void Main(string[] args)
    {
        AsyncAwait.AwaitMethod();
        Console.WriteLine("Main Thread 1st output ..." );
        Console.WriteLine("Main Thread 2st output ...");
        Console.WriteLine();
        Console.ReadLine();
    }

    
}

}




