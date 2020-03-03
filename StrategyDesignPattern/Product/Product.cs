using System;
using System.Collections.Specialized;

namespace StrategyDesignPattern
{
    public class Product
    {
        public int ProductId{ get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
            var random = new Random();
            ProductId = random.Next(1,100000);
        }
    }
}