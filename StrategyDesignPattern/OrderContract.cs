using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using StrategyDesignPattern.Interface;

namespace StrategyDesignPattern
{
    public abstract class OrderContract
    {
        public int OrderId { get; }
        public abstract ITax Tax { get; set; }
        public List<Product> Products { get; set; }

        protected OrderContract()
        {
            var random = new Random();
            OrderId = random.Next(1, 100);
            Products = new List<Product>();
        }

        public abstract void SetTax(ITax tax);

        public void GetTotal()
        {
            if (!Products.Any())
            {
                Console.WriteLine("Please insert a product"); 
                return;
            }

            var totalProduct = Products.Sum(m => m.Price);
            var total = totalProduct + (totalProduct * Tax.GetTaxValue());
            Console.WriteLine(total);
        }

        public void GetLocation()
        {
            Console.WriteLine(Tax.GetTaxLocation());
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
