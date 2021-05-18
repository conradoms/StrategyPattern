using System;
namespace StrategyPattern.Services.Interfaces
{
    public interface IShippingService
    {
        double CalculateShippingFee(int desiredShippingCompanyCode,
            double weigth);
    }
}
