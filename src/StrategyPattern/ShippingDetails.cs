using System;
namespace StrategyPattern
{
    public class ShippingDetails
    {
        public ShippingDetails(string shippingCompanyName, double packageWeigth
            , double shippingTotalCost)
        {
            ShippingCompanyName = shippingCompanyName;
            PackageWeigth = packageWeigth;
            ShippingTotalCost = shippingTotalCost;
        }

        public string ShippingCompanyName { get; set; }
        public double PackageWeigth { get; set; }
        public double ShippingTotalCost { get; set; }
    }
}
