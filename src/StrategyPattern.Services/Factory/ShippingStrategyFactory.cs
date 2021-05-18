using System;
using System.Collections.Generic;
using StrategyPattern.Services.ShippingStrategy;

namespace StrategyPattern.Services.Factory
{
    // Created by: Conrado Silva
    // Date: 18/05/2021
    // Description: This factory is responsible to create objects that represents the strategy
    // selected according to the given desired shipping company code. All this objects
    // implements IShippingStrategy interface, that defines a contract containing
    // Calculate method, responsible for calculating shipping fee.

    public class ShippingStrategyFactory : IShippingStrategyFactory
    {
        Dictionary<int, IShippingStrategy> shippingStrategyMap = new Dictionary<int, IShippingStrategy>();

        public ShippingStrategyFactory()
        {
            shippingStrategyMap.Add(1, new TNT());
            shippingStrategyMap.Add(2, new Sedex());
            shippingStrategyMap.Add(3, new JadLog());
            shippingStrategyMap.Add(4, new BrassPress());
            shippingStrategyMap.Add(5, new DHL());
        }

        public IShippingStrategy Create(int desiredShippingCompanyCode)
        {
            return shippingStrategyMap[desiredShippingCompanyCode];
        }
    }
}
