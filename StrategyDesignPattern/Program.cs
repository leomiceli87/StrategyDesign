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
            Console.WriteLine("- List of products");
            orderCarlos.GetProductList();
            Console.WriteLine("- Total");
            orderCarlos.GetTotal();
            Console.WriteLine("- Place");
            orderCarlos.GetLocation();

            Thread.Sleep(100000);

            Console.WriteLine("test");
        }
    }
}
