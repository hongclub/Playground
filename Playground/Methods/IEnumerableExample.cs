using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public static class IEnumerableExample
    {


        //public static void test()
        //{

        //    IEnumerable<string> result;
        //    List<string> list1 = new List<String>();

        //    list1.Add("A");
        //    list1.Add("B");


        //    List<string> list2 = new List<String>();

        //    list2.Add("A");
        //    list2.Add("A");
        //    list2.Add("B");

        //    // Append
        //    result = list1;
        //    result = result.Concat(new[] { "C" });
        //    //// work: result = result.Concat(new[] { "C" });

        //    //// AsEnumerable 
        //    //result = list2.Where(x => x == "A");
        //    //// work: result = list2.Where(x => x == "A");

        //    //// Empty
        //    //result = Enumerable.Empty<string>();
        //    //list2.Clear();
        //    //// work: result = Enumerable.Empty<string>();


        //    var paymentIdToDetailItemsHashTable = new Hashtable();

        //    paymentIdToDetailItemsHashTable.Add(1, new List<string>());
        //    paymentIdToDetailItemsHashTable.Add(2, result);

        //    // var pmtDetailItems = paymentIdToDetailItemsHashTable[1];
        //    var pmtDetailItems = paymentIdToDetailItemsHashTable[2];

        //    if (pmtDetailItems is IEnumerable<string>)
        //    {
        //        (pmtDetailItems as List<string>).ForEach(dataItem =>
        //        {
        //            dataItem = "ASFASDF";
        //        });


        //    }



        //    Console.Write(string.Join(", ", result));
        //}


        public static void test()
        {

            IEnumerable<NachaStagedPaymentDetailItem> result = new List<NachaStagedPaymentDetailItem>();
            List<NachaStagedPaymentDetailItem> list1 = new List<NachaStagedPaymentDetailItem>();

            NachaStagedPaymentDetailItem a = new NachaStagedPaymentDetailItem()
            {
                StagedPaymentDetailId = 1
            };

            NachaStagedPaymentDetailItem b = new NachaStagedPaymentDetailItem()
            {
                StagedPaymentDetailId = 2
            };

            NachaStagedPaymentDetailItem c = new NachaStagedPaymentDetailItem()
            {
                StagedPaymentDetailId = 3
            };



            list1.Add(a);
            list1.Add(b);
            list1.Add(c);

            result = list1.Where(x => x.StagedPaymentDetailId == 1);



            var paymentIdToDetailItemsHashTable = new Hashtable();

            paymentIdToDetailItemsHashTable.Add(1, new List<NachaStagedPaymentDetailItem>());
            paymentIdToDetailItemsHashTable.Add(2, result);

            var paymentDetailItemList = new List<NachaStagedPaymentDetailItem>();

            //var pmtDetailItems = paymentIdToDetailItemsHashTable[1];
            var pmtDetailItems = paymentIdToDetailItemsHashTable[2];

            if (pmtDetailItems is IEnumerable<NachaStagedPaymentDetailItem>)
            {
                //foreach (var dataItem in (pmtDetailItems as IEnumerable<NachaStagedPaymentDetailItem>))
                //{
                //    dataItem.StagedPaymentDetailId = dataItem.StagedPaymentDetailId + 100;
                //    paymentDetailItemList.Add(dataItem);
                //}

                (pmtDetailItems as List<NachaStagedPaymentDetailItem>).ForEach(dataItem =>
                {
                    dataItem.StagedPaymentDetailId = dataItem.StagedPaymentDetailId + 100;
                    paymentDetailItemList.Add(dataItem);
                });


            }
            else
            {
                throw new Exception();
            }



            Console.Write(string.Join(", ", result));
        }
    }
}
