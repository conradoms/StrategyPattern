using System;
using System.Collections.Generic;

namespace StrategyPattern.Services.Models
{
    public class ShippingCompany
    {
        public int CompanyCode { get; private set; }
        public string CompanyName { get; private set; }

        public ShippingCompany(int companyCode, string companyName)
        {
            CompanyCode = companyCode;
            CompanyName = companyName;
        }

        public bool IsValid()
        {
            return this == null;
        }
    }
}
