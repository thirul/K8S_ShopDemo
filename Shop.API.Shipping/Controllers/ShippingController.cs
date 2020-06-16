using Microsoft.AspNetCore.Mvc;
using Shop.API.Product.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.API.Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingController : ControllerBase
    {
        
        public async Task<IEnumerable< ShippingModel >> Get()
        {
            return ShippingMock.BuildProducts();
        }
    }
}
