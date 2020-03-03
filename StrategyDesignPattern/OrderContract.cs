using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class OrderContract
    {
        public int OrderId { get; }
        public decimal Tax { get;}
        public List<Product> Products { get; set; }

        public OrderContract()
        {
            var random = new Random();
            Tax = (decimal) 0.05;
            OrderId = random.Next(1, 100);
            Products = new List<Product>();
        }

        public void GetTotal()
        {
            if (!Products.Any())
            {
                Console.WriteLine("Please insert a product"); 
                return;
            }
                

            var totalProduct = Products.Sum(m => m.Price);
            var total = totalProduct + (totalProduct * Tax);
            Console.WriteLine(total);
        }

        public void GetProductList()
        {
            if (!Products.Any())
            {
                Console.WriteLine("Please insert a product");
                return;
            }

            Products.ForEach(product =>
            {
                Console.WriteLine(product.Name);
            });
        }
    }
}
