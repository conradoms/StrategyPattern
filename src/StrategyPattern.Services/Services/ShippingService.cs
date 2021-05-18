using System;
using StrategyPattern.Services.Factory;
using StrategyPattern.Services.Interfaces;

namespace StrategyPattern.Services.Services
{
    // Created by: Conrado Silva
    // Date: 18/05/2021

    // Description: This class is responsible to receive the desired shipping company code
    // and package's weigth and calculate the fee according to the company desired.
    // The factory instantiate a object that implements IShippingStrategy and
    // will be used by CalculateShippingFee method to calculate fee.

    public class ShippingService : IShippingService
    {
        private readonly IShippingStrategyFactory _shippingStrategyFactory;

        public ShippingService(IShippingStrategyFactory shippingStrategyFactory)
        {
            _shippingStrategyFactory = shippingStrategyFactory;
        }

        public double CalculateShippingFee(int desiredShippingCompanyCode,
            double weigth)
        {
            // Delegates the creation of objects to a factory keep the coupling low
            var shippingStrategy = _shippingStrategyFactory.Create(desiredShippingCompanyCode);

            // Uses created strategy object to calculate fee
            return shippingStrategy.Calculate(weigth);
        }
    }
}
