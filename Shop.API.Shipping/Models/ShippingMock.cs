using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.API.Product.Models
{
    public static class ShippingMock
    {
        public static  IEnumerable<ShippingModel> BuildProducts()
        {
            return new List<ShippingModel> {
                new ShippingModel{ Id = 100, Status = "Not shipped", ShippingDate = DateTime.Now.AddDays(10), Address = "16 Bridge Rd, Hounslow, UK TW3 1PG"},
                new ShippingModel{ Id = 101, Status = "shipped", ShippingDate = DateTime.Now.AddDays(-1), Address = "21 Bridge Rd, Hounslow, UK TW3 1PG"},
                new ShippingModel{ Id = 102, Status = "shipped", ShippingDate = DateTime.Now.AddDays(-10), Address = "Flat 2, 664 London Rd, Hounslow, UK TW3 1PG"},
                new ShippingModel{ Id = 103, Status = "Not shipped", ShippingDate = DateTime.Now.AddDays(10), Address = "Flat 1, 666 London Rd, Hounslow, UK TW3 1PG"},
                new ShippingModel{ Id = 104, Status = "Not shipped", ShippingDate = DateTime.Now.AddDays(10), Address = "Flat 3, London Rd, UK TW3 1PG"}
            };
        }
    }
}
