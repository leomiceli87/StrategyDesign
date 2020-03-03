using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using StrategyDesignPattern.Order;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderCarlos = new OrderCarlosVancouver();
            orderCarlos.SetProducts();
            orderCarlos.GetProductList();
            orderCarlos.GetTotal();

            Thread.Sleep(100000);

            Console.WriteLine("test");
        }
    }
}
