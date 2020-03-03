using StrategyDesignPattern.Interface;

namespace StrategyDesignPattern.Tax
{
    public class VancouverTax : ITax
    {
        public decimal Value { get; set; }
        public string PlaceName { get; set; }

        public VancouverTax()
        {
            Value = (decimal)0.05;
            PlaceName = "Vancouver";
        }

        public void SetTaxInformation(decimal value, string placeName)
        {
            Value = value;
            PlaceName = placeName;
        }

        public decimal GetTaxValue()
        {
            return Value;
        }

        public string GetTaxLocation()
        {
            return PlaceName;
        }
    }
}