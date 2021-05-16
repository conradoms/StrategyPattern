using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StrategyPattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShippingController : ControllerBase
    {
        [HttpGet]
        public ShippingDetails Get(double packageWeigth, int shippingCompanyCode)
        {
            double shippingCost = 0;
            string shippingCompanyName = string.Empty;

            if (shippingCompanyCode == 1)
            {
                shippingCost = packageWeigth * 1.50;
            }
            else if (shippingCompanyCode == 2)
            {
                shippingCost = packageWeigth * 0.85;
            }
            else if (shippingCompanyCode == 3)
            {
                shippingCost = packageWeigth * 5.5;
            }
            else if (shippingCompanyCode == 4)
            {
                shippingCost = packageWeigth * 2.95;
            }
            else if (shippingCompanyCode == 5)
            {
                shippingCost = packageWeigth * 11.95;
            }

            switch (shippingCompanyCode)
            {
                case 1:
                    shippingCompanyName = "TNT";
                    break;
                case 2:
                    shippingCompanyName = "Sedex";
                    break;
                case 3:
                    shippingCompanyName = "JadLog";
                    break;
                case 4:
                    shippingCompanyName = "BrassPress";
                    break;
                case 5:
                    shippingCompanyName = "DHL";
                    break;
            }

            ShippingDetails shippingDetails = new ShippingDetails(shippingCompanyName, packageWeigth, shippingCost);

            return shippingDetails;
        }
    }
}
