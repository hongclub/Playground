using Playground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ref: https://www.codeproject.com/Articles/652556/Can-you-explain-Lazy-Loading
namespace Playground.Methods
{
    class LazyLoadingExample
    {
        private Lazy<List<Order>> _Orders = null;
        private string _CustomerName = string.Empty;
        public List<Order> Orders
        {
            get
            {
                return _Orders.Value;
            }
        }

        public string CustomerName
        {
            get
            {
                return _CustomerName;
            }
        }

        //constructor
        public LazyLoadingExample()
        {
            _CustomerName = "Tommy";
            _Orders = new Lazy<List<Order>>(() => LoadOrders());    // it won't load until you call Orders explicitly

        }

        private List<Order> LoadOrders()
        {
            List<Order> temp = new List<Order>();
            Order o = new Order();
            o.OrderNumber = "ord1001";
            temp.Add(o);
            o = new Order();
            o.OrderNumber = "ord1002";
            temp.Add(o);
            return temp;
        }
    }
}
