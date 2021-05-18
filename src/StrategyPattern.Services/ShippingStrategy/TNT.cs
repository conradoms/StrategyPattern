using System;
namespace StrategyPattern.Services.ShippingStrategy
{
    public class TNT : IShippingStrategy
    {
        public TNT()
        {

        }

        public double Calculate(double weigth)
        {
            return weigth * 1.50;
        }
    }
}
