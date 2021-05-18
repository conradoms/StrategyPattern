using System;
using StrategyPattern.Services.ShippingStrategy;

namespace StrategyPattern.Services.Factory
{
    // Created by: Conrado Silva
    // Date: 18/05/2021
    // Description: This interface is implemented by classes that holds business rules

    public interface IShippingStrategyFactory
    {
        IShippingStrategy Create(int desiredShippingCompanyCode);
    }
}
