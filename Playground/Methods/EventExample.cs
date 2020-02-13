using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ref https://www.tutorialsteacher.com/csharp/csharp-event
namespace Playground.Methods
{
    public static class EventExample
    {
        public static void Test()
        {
            Number n = new Number(10);  // this will send up the Number constructor
            n.PrintMoney();
            n.PrintNumber();
        }
           
    }

    public class Number
    {
        private PrintHelper _printHelper;
        private int _value;

        // constructor
        public Number(int val)
        {
            _value = val;
            _printHelper = new PrintHelper();
            _printHelper.beforePrintEvent += printHelper_beforePrintEventHandler;  //subscribe and pay attention to beforePrintEvent event
        }
        //beforePrintevent handler
        void printHelper_beforePrintEventHandler(string message)
        {
            Console.WriteLine("BeforePrintEvent warning fires from {0}", message);
        }

        public void PrintMoney()
        {
            _printHelper.PrintMoney(_value);
        }

        public void PrintNumber()
        {
            _printHelper.PrintNumber(_value);
        }

    }
    public class PrintHelper
    {
        // create some delegate
        public delegate void BeforePrint(string message);
        public event BeforePrint beforePrintEvent;

        public PrintHelper()
        {

        }

        public void PrintNumber(int num)
        {
            if (beforePrintEvent != null)
                beforePrintEvent.Invoke("PrintNumber");     // publish the event to print the warning message

            Console.WriteLine("Number: {0,-12:N0}", num);

        }


        public void PrintMoney(int money)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("PrintMoney");             // publish the event to print the warning message

            Console.WriteLine("Money: {0:C}", money);       
        }
    }
}
