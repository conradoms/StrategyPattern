using System;
using StrategyPattern.Services.Interfaces;
using StrategyPattern.Services.Models;

namespace StrategyPattern.Services.Services
{
    public class ShippingService : IShippingService
    {
        public ShippingService()
        {
        }

        public double CalculateShippingFee(int desiredShippingCompanyCode,
            double weigth)
        {
            double shippingCost = 0;

            if (desiredShippingCompanyCode == 1)
            {
                shippingCost = weigth * 1.50;
            }
            else if (desiredShippingCompanyCode == 2)
            {
                shippingCost = weigth * 0.85;
            }
            else if (desiredShippingCompanyCode == 3)
            {
                shippingCost = weigth * 5.5;
            }
            else if (desiredShippingCompanyCode == 4)
            {
                shippingCost = weigth * 2.95;
            }
            else if (desiredShippingCompanyCode == 5)
            {
                shippingCost = weigth * 11.95;
            }

            return shippingCost;
        }
    }
}
