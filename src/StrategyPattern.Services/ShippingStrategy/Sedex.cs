using System;
namespace StrategyPattern.Services.ShippingStrategy
{
    public class Sedex : IShippingStrategy
    {
        public Sedex()
        {
        }

        public double Calculate(double weigth)
        {
            return weigth * 0.85;
        }
    }
}
