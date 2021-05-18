using System;
using System.Collections.Generic;
using StrategyPattern.Services.Interfaces;
using StrategyPattern.Services.Models;

namespace StrategyPattern.Services.Services
{
    public class ShippingCompanyService : IShippingCompanyService
    {
        public ShippingCompanyService()
        {
        }

        private List<ShippingCompany> shippingCompanies = new List<ShippingCompany>
        {
            new ShippingCompany(1, "TNT"),
            new ShippingCompany(2, "Sedex"),
            new ShippingCompany(3, "JadLog"),
            new ShippingCompany(4, "BrassPress"),
            new ShippingCompany(5, "DHL"),
        };

        public ShippingCompany GetByCompanyCod(int companyCode)
        {
            var shippingCompany = shippingCompanies.Find(x => x.CompanyCode == companyCode);

            return shippingCompany;
        }
    }
}
