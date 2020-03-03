using System.Runtime.InteropServices;
using StrategyDesignPattern.Interface;
using StrategyDesignPattern.Tax;

namespace StrategyDesignPattern.Order
{
    public class OrderCarlosVancouver: OrderContract
    {
        public override ITax Tax { get; set; }

        public OrderCarlosVancouver()
        {
            Tax = new VancouverTax();
        }

        public void SetProducts()
        {
            var product01 = new Product
            {
                Price = 15,
                Name = "Mouse",
            };
            var product02 = new Product
            {
                Price = 20,
                Name = "Keyboard",
            };

            Products.Add(product01);
            Products.Add(product02);
        }

        
        public override void SetTax(ITax tax)
        {
            Tax = tax;
        }
    }
}