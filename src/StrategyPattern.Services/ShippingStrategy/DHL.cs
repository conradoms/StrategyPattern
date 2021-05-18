using System;
namespace StrategyPattern.Services.ShippingStrategy
{
    public class DHL : IShippingStrategy
    {
        public DHL()
        {
        }

        public double Calculate(double weigth)
        {
            return weigth * 11.95;
        }
    }
}
