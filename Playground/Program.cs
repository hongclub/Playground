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
using System.Net.Http;



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

/////////////////////////////////////////////////////////////////////////////////////////////////////////// 

///////////////////////////////////////////////////////////////////////////////////////////////////////////////// 

//// Test : AsyncAwait.cs
/////////////////////////////////////////////////////////////////////////////////////////////////////////
//// <summary>
///// 
///// class: await a thread
///// </summary>
//namespace Playground
//{
//    public class Demo
//    {
//        public static void Main(string[] args)
//        {
//            AsyncAwait.WithoutAwaitMethod();
//            Console.WriteLine("Main Thread 1st output ...");
//            Console.WriteLine("Main Thread 2st output ...");
//            Console.WriteLine();
//            Console.ReadLine();
//        }




//    }

//}


///////////////////////////////////////////////////////////////////////////////////////////////////////// 

/////////////////////////////////////////////////////////////////////////////////////////////////////////////// 

//// Test : AsyncAwait.cs
/////////////////////////////////////////////////////////////////////////////////////////////////////////
//// <summary>
///// 
///// class: await a thread
///// </summary>
//namespace Playground
//{
//    public class Demo
//    {
//        //static Random rand = new Random();

//        //static void Main()
//        //{
//        //    // Wait on a single task with no timeout specified.
//        //    Task taskA = Task.Run(() => Thread.Sleep(2000));
//        //    Console.WriteLine("taskA Status: {0}", taskA.Status);
//        //    try
//        //    {
//        //        taskA.Wait(30000);   // wait until it is finished
//        //        Console.WriteLine("taskA Status: {0}", taskA.Status);
//        //    }
//        //    catch (AggregateException)
//        //    {
//        //        Console.WriteLine("Exception in taskA.");
//        //    }

//        //    Console.ReadLine();
//        //}


//        //public static void Main()
//        //{
//        //    var tasks = new Task[3];
//        //    var rnd = new Random();
//        //    for (int ctr = 0; ctr <= 2; ctr++)
//        //        tasks[ctr] = Task.Run(() => Thread.Sleep(rnd.Next(500, 3000)));

//        //    try
//        //    {
//        //        // int index = Task.WaitAny(tasks);
//        //        Console.WriteLine("Task #{0} completed first.\n", tasks[index].Id);
//        //        Console.WriteLine("Status of all tasks:");
//        //        foreach (var t in tasks)
//        //            Console.WriteLine("   Task #{0}: {1}", t.Id, t.Status);
//        //    }
//        //    catch (AggregateException)
//        //    {
//        //        Console.WriteLine("An exception occurred.");
//        //    }

//        //    Console.ReadLine();
//        //}


//        //public static async Task Main()
//        //{
//        //    // Wait for all tasks to complete.
//        //    //Task[] tasks = new Task[10];
//        //    List<Task> tasks = new List<Task>();
//        //    for (int i = 0; i < 10; i++)
//        //    {
//        //        //tasks[i] = Task.Run(() => Thread.Sleep(2000));
//        //        tasks.Add(Task.Run(() => Thread.Sleep(2000)));
//        //    }
//        //    try
//        //    {
//        //        //  Task.WaitAny(tasks);
//        //       await Task.WhenAll(tasks);
//        //    }
//        //    catch (AggregateException ae)
//        //    {
//        //        Console.WriteLine("One or more exceptions occurred: ");
//        //        foreach (var ex in ae.Flatten().InnerExceptions)
//        //            Console.WriteLine("   {0}", ex.Message);
//        //    }

//        //    Console.WriteLine("Status of completed tasks:");
//        //    foreach (var t in tasks)
//        //        Console.WriteLine("   Task #{0}: {1}", t.Id, t.Status);

//        //    Console.ReadLine();
//        //}




//  }

//}


/////////////////////////////////////////////////////////////////////////////////////////////////////////// 

///////////////////////////////////////////////////////////////////////////////////////////////////////////////// 

//// Test : AsyncAwait.cs
/////////////////////////////////////////////////////////////////////////////////////////////////////////
//// <summary>
///// 
///// class: await a thread
///// </summary>
//namespace Playground
//{
//    public class Demo
//    {
//        public static async Task<int> Main(string[] args)
//        {
//            // You need to add a reference to System.Net.Http to declare client.
//            var client = new HttpClient();

//            // GetStringAsync returns a Task<string>. That means that when you await the
//            // task you'll get a string (urlContents).
//            Task<string> getStringTask = client.GetStringAsync("https://docs.microsoft.com/dotnet");
//            string urlContents = await getStringTask;

//            // You can do work here that doesn't rely on the string from GetStringAsync.
//            Console.WriteLine("do some other stuff");

//            // The await operator suspends AccessTheWebAsync.
//            //  - AccessTheWebAsync can't continue until getStringTask is complete.
//            //  - Meanwhile, control returns to the caller of AccessTheWebAsync.
//            //  - Control resumes here when getStringTask is complete.
//            //  - The await operator then retrieves the string result from getStringTask.


//            Console.WriteLine(urlContents.Substring(0, 100));
//            Console.ReadLine();
//            // The return statement specifies an integer result.
//            // Any methods that are awaiting AccessTheWebAsync retrieve the length value.
//            return urlContents.Length;

//        }




//    }

//}


///////////////////////////////////////////////////////////////////////////////////////////////////////// 

/////////////////////////////////////////////////////////////////////////////////////////////////////////////// 

// Test : AsyncAwait.cs
///////////////////////////////////////////////////////////////////////////////////////////////////////
// <summary>


//namespace Playground
//{
//    public class Demo
//    {
//        //public static async Task<int> Main(string[] args)
//        //{
//        //    // You need to add a reference to System.Net.Http to declare client.
//        //    Task<int> returnedTaskTResult = GetTaskOfTResultAsync();
//        //    int intResult = await returnedTaskTResult;
//        //    // or, in a single statement
//        //    //int intResult = await GetTaskOfTResultAsync();
//        //    Console.WriteLine(intResult);
//        //    Console.ReadLine();
//        //    return 1;

//        //}


//        //public static async Task<int> GetTaskOfTResultAsync()
//        //{
//        //    int hours = 0;
//        //    await Task.Delay(10000);
//        //    // Return statement specifies an integer result.
//        //    return hours;
//        //}


//        //public static void Main(string[] args)
//        //{
//        //    GetTaskOfTResultAsync();

//        //}


//        //public static async void GetTaskOfTResultAsync()
//        //{
//        //    await Task.Delay(10000);

//        //}


//        //public static async Task Main(string[] args)
//        //{
//        //    var sw = Stopwatch.StartNew();
//        //    var tasks = new List<Task>();
//        //    for (int i = 1; i < 4; i++)
//        //    {
//        //        // tasks.Add(CreateMoneyFlowTransaction1(i));
//        //        tasks.Add(CreateMoneyFlowTransaction1(i));
//        //    }
//        //    await Task.WhenAll(tasks);

//        //    // You need to add a reference to System.Net.Http to declare client.
//        //    //Task<int> returnedTaskTResult = GetTaskOfTResultAsync();
//        //    //int intResult = await returnedTaskTResult;
//        //    // or, in a single statement
//        //    //int intResult = await GetTaskOfTResultAsync();
//        //    Console.WriteLine(sw.ElapsedMilliseconds);
//        //    foreach (var t in tasks)
//        //        Console.WriteLine(t.Status);
//        //    Console.ReadLine();

//        //}


//        //public static async Task Main(string[] args)
//        //{
//        //    await CreateMoneyFlowDetail();
//        //    Console.WriteLine("i am out");
//        //    Console.ReadLine();

//        //}

//        //public static async Task CreateMoneyFlowDetail()
//        //{
//        //    var sw = Stopwatch.StartNew();
//        //    var tasks = new List<Task>();
//        //    for (int i = 1; i < 4; i++)
//        //    {
//        //        // tasks.Add(CreateMoneyFlowTransaction1(i));
//        //        tasks.Add(CreateMoneyFlowTransaction1(i));
//        //    }
//        //    await Task.WhenAll(tasks);

//        //    // You need to add a reference to System.Net.Http to declare client.
//        //    //Task<int> returnedTaskTResult = GetTaskOfTResultAsync();
//        //    //int intResult = await returnedTaskTResult;
//        //    // or, in a single statement
//        //    //int intResult = await GetTaskOfTResultAsync();
//        //    Console.WriteLine(sw.ElapsedMilliseconds);
//        //    foreach (var t in tasks)
//        //        Console.WriteLine(t.Status);
//        //    Console.ReadLine();

//        //}


//        //public static async Task CreateMoneyFlowTransaction1(int i)
//        //{

//        //    await CreateMoneyFlowTransaction2(i);
//        //    Console.WriteLine("Inside CreateMoneyFlowTransaction1: " + i);
//        //    int hours = 0;
//        //}

//        //public static async Task<int> CreateMoneyFlowTransaction2(int i)
//        //{
//        //    Console.WriteLine("Starting: " + i);
//        //    int hours = 0;
//        //    await Task.Run(() => Thread.Sleep(10000));
//        //    //await Task.Delay(10000 * i);
//        //    // Return statement specifies an integer result.
//        //    return hours;

//        //    //Console.WriteLine("Starting: " + i);
//        //    //int hours = 0;
//        //    //await Task.Delay(10000 * i);
//        //    //// Return statement specifies an integer result.
//        //    //return hours;
//        //}


//        //public static Task SomeLongOperation()
//        //{
//        //    return Task.Delay(3000);
//        //}

//        //static void Main(string[] args)
//        //{

//        //    List<Task> tasks = new List<Task>();

//        //    tasks.Add(Task.Factory.StartNew(() => SomeLongOperation()));
//        //    tasks.Add(Task.Factory.StartNew(() => SomeLongOperation()));

//        //    var arr = tasks.ToArray();

//        //    Stopwatch sw = Stopwatch.StartNew();
//        //    Task.WaitAll(arr);
//        //    Console.WriteLine("Task wait all results: " + sw.Elapsed);
//        //    sw.Stop();

//        //    sw = Stopwatch.StartNew();
//        //    Parallel.Invoke(() => SomeLongOperation(), () => SomeLongOperation());
//        //    Console.WriteLine("Parallel invoke results: " + sw.Elapsed);
//        //    sw.Stop();

//        //    Console.ReadKey();
//        //}


//        public static void Main(string[] args)
//        {


//            StaticVariable s = new StaticVariable();
//        }

//        public static void Method1()
//        {
//            Tutorial.Topic = "tommy class";
//        }





//    }



//    public class Tutorial2
//    {
//        // Static data members of Tutorial 
//        public string Topic = "Static class";
//    }

//}



/////// Test : StaticVariable.cs
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////// <summary>
/////// 
/////// class: StaticVariable.cs
/////// Test : StaticVariable.cs
/////// </summary>
//namespace Playground
//{
//    public class Demo
//    {
//        public static void Main(string[] args)
//        {
//            // static variable belongs to the class
//            // once change the static variable, it will change forever for that class
//            StaticVariable.displayStatic();
//            StaticVariable.staticV = "Change Static variable";
//            StaticVariable.displayStatic();

//            // nonstatic variable belongs to the object
//            StaticVariable s1 = new StaticVariable();
//            StaticVariable s2= new StaticVariable();
//            s1.nonStaticV = "Change nonStatic variable 1";
//            StaticVariable.displayStatic();
//            Console.WriteLine(s1.nonStaticV);
//            Console.WriteLine(s2.nonStaticV);

//            Console.ReadLine();
//        }

//    }
//}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////  



/////// Test : IEnumerableVsIQueryable.cs
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////// <summary>
/////// 
/////// class: IEnumerableVsIQueryable.cs
/////// Test : IEnumerableVsIQueryable.cs
/////// </summary>
//namespace Playground
//{
//    public class Demo
//    {
//        public static void Main(string[] args)
//        {
//            IEnumerableVsIQueryable.test();
//            Console.ReadLine();
//        }

//    }
//}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////  


/////// Test : GenericExample.cs
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////// <summary>
/////// 
/////// class: GenericExample.cs
/////// Test : GenericExample.cs
/////// </summary>
//namespace Playground
//{
//    public class Demo
//    {
//        public static void Main(string[] args)
//        {
//            GenericClassExample<int> intGenericClass = new GenericClassExample<int>(10);
//            int intVal = intGenericClass.genericMethod(200);

//            GenericClassExample<string> stringGenericClass = new GenericClassExample<string>("TOMMY");
//            string stringVal = stringGenericClass.genericMethod("WAI");



//            Console.ReadLine();
//        }

//    }
//}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////  




/////// Test : VirtualMethod.cs
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////// <summary>
/////// 
/////// class: VirtualMethod.cs
/////// Test : VirtualMethod.cs
/////// </summary>
//namespace Playground
//{
//    public class Demo
//    {
//        public static void Main(string[] args)
//        {
//            Shape s = new Shape(1,2);
//            s.area();
//            Rectange r = new Rectange(2, 2);
//            r.area();
//            Console.ReadLine();

//        }

//    }
//}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////  


/////// Test : AbstractMethod.cs
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////// <summary>
/////// 
/////// class: AbstractMethod.cs
/////// Test : AbstractMethod.cs
/////// </summary>
//namespace Playground
//{
//    public class Demo
//    {
//        public static void Main(string[] args)
//        {
//            // Vehicle s = new Vehicle();  // you cannot do that, cannot create a new instant of abstract class
//            Vehicle s;
//            s = new Car();              // Polymorphism
//            s.Driving();
//            s = new Bus();              // Polymorphism
//            s.Driving();

//            Console.ReadLine();

//        }

//    }
//}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////  



/////// Test : DelegateExample.cs
///////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////// <summary>
/////// 
/////// class: DelegateExample.cs
/////// Test : DelegateExample.cs
/////// </summary>
//namespace Playground
//{
//    public class Demo
//    {
//        public static void Main(string[] args)
//        {
//            DelegateExample.Test();
//        }
//    }
//}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////  


/////// Test : DelegateFuncExample.cs
///////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////// <summary>
/////// 
/////// class: DelegateFuncExample.cs
/////// Test : DelegateFuncExample.cs
/////// </summary>
//namespace Playground
//{
//    public class Demo
//    {
//        public static void Main(string[] args)
//        {
//            // DelegateFuncExample.Test();
//            DelegateFuncExample.TestSimpleVersion();
//        }
//    }
//}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////  


/////// Test : DelegateActionExample.cs
///////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////// <summary>
/////// 
/////// class: DelegateActionExample.cs
/////// Test : DelegateActionExample.cs
/////// </summary>
//namespace Playground
//{
//    public class Demo
//    {
//        public static void Main(string[] args)
//        {
//            // DelegateFuncExample.Test();
//            DelegateActionExample.TestSimpleVersion();
//        }
//    }
//}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////  



/////// Test : DelegateActionExample.cs
///////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////// <summary>
/////// 
/////// class: DelegateActionExample.cs
/////// Test : DelegateActionExample.cs
/////// </summary>
//namespace Playground
//{
//    public class Demo
//    {
//        public static void Main(string[] args)
//        {

//            EventExample.Test();
//            Console.ReadLine();
//        }
//    }
//}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////// 

/////// Test : DelegateActionExample.cs
///////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////// <summary>
/////// 
/////// class: DelegateActionExample.cs
/////// Test : DelegateActionExample.cs
/////// </summary>
//namespace Playground
//{
//    public class Demo
//    {
//        public static void Main(string[] args)
//        {

//            object d = getSomething();
//            Console.WriteLine(d);
//            Console.ReadLine();
//        }

//        public static object getSomething()
//        {
//            return "test";
//        }
//    }
//}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////  


///////////////////////////////////////////////////////////////////////////////////////////////////////////// 

/////// Test : BaseExample.cs
///////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////// <summary>
/////// 
/////// class: BaseExample.cs
/////// Test : BaseExample.cs
/////// </summary>
//namespace Playground
//{
//    public class Demo
//    {
//        public static void Main(string[] args)
//        {
//            BaseExample.TestBase();
//            Console.ReadLine();
//        }
//    }
//}
/////////////////////////////////////////////////////////////////////////////////////////////////////////////  


/////// Test : ThisExample.cs
///////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////// <summary>
/////// 
/////// class: ThisExample.cs
/////// Test : ThisExample.cs
/////// </summary>
//namespace Playground
//{
//    public class Demo
//    {
//        public static void Main(string[] args)
//        {
//            ThisExample.TestThis();
//            Console.ReadLine();
//        }
//    }
//}
///////////////////////////////////////////////////////////////////////////////////////////////////////////// 


///// Test : IsVsAs.cs
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
///// <summary>
///// 
///// class: IsVsAs.cs
///// Test : IsVsAs.cs
///// </summary>
namespace Playground
{
    public class Demo
    {
        public static void Main(string[] args)
        {
            IsVsAs.TestIs();
            Console.ReadLine();
        }
    }
}
///////////////////////////////////////////////////////////////////////////////////////////////////////////  










