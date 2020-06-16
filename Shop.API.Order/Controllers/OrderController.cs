using Microsoft.AspNetCore.Mvc;
using Shop.API.Order.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.API.Order.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        public async Task<IEnumerable<OrderModel>> Get() {
            return OrderMock.BuildOrders();
        }
    }
}
