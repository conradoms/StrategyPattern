using System;
namespace StrategyPattern.Services.ShippingStrategy
{
    public class JadLog : IShippingStrategy
    {
        public JadLog()
        {
        }

        public double Calculate(double weigth)
        {
            return weigth * 5.5;
        }
    }
}
