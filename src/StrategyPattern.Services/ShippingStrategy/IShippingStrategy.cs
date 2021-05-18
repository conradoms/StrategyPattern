using System;
namespace StrategyPattern.Services.ShippingStrategy
{
    public interface IShippingStrategy
    {
        double Calculate(double weigth);
    }
}
