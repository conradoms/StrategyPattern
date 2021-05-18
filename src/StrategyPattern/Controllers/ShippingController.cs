using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StrategyPattern.Services.Services;
using StrategyPattern.ViewModel;

namespace StrategyPattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShippingController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get(double packageWeigth, int shippingCompanyCode)
        {
            var shippingService = new ShippingService();
            var companyService = new ShippingCompanyService();

            var company = companyService.GetByCompanyCod(shippingCompanyCode);

            if (company == null) return BadRequest(new ReturnViewModel(false, "Company not found"));

            var shippingDetails = new ShippingDetails(company.CompanyName,
                packageWeigth, shippingService.CalculateShippingFee(shippingCompanyCode, packageWeigth));

            return Ok(new ReturnViewModel(true, string.Empty, shippingDetails));
        }
    }
}
