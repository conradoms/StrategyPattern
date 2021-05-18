using Microsoft.AspNetCore.Mvc;
using StrategyPattern.Services.Interfaces;
using StrategyPattern.ViewModel;

namespace StrategyPattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShippingController : ControllerBase
    {
        public readonly IShippingService _shippingService;
        public readonly IShippingCompanyService _shippingCompanyService;

        public ShippingController(
            IShippingService shippingService,
            IShippingCompanyService shippingCompanyService)
        {
            _shippingService = shippingService;
            _shippingCompanyService = shippingCompanyService;
        }

        [HttpGet]
        public ActionResult Get(double packageWeigth, int shippingCompanyCode)
        {
            var company = _shippingCompanyService.GetByCompanyCod(shippingCompanyCode);

            if (company == null) return BadRequest(new ReturnViewModel(false, "Company not found"));

            var shippingDetails = new ShippingDetails(company.CompanyName,
                packageWeigth, _shippingService.CalculateShippingFee(shippingCompanyCode, packageWeigth));

            return Ok(new ReturnViewModel(true, string.Empty, shippingDetails));
        }
    }
}
