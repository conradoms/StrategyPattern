using System;
namespace StrategyPattern.Services.ShippingStrategy
{
    public class BrassPress : IShippingStrategy
    {
        public BrassPress()
        {
        }

        public double Calculate(double weigth)
        {
            return weigth * 2.95;
        }
    }
}
