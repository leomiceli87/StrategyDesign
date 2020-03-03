using System.Runtime.InteropServices;

namespace StrategyDesignPattern.Order
{
    public class OrderCarlosVancouver: OrderContract
    {
        public OrderCarlosVancouver() : base()
        {
            
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
    }
}