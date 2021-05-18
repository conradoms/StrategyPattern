using System;
using StrategyPattern.Services.Models;

namespace StrategyPattern.Services.Interfaces
{
    public interface IShippingCompanyService
    {
        ShippingCompany GetByCompanyCod(int companyCode);
    }
}
