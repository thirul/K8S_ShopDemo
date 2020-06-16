using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.API.Order.Models
{
    public static class OrderMock
    {
        public static IEnumerable<OrderModel> BuildOrders()
        {
            return new List<OrderModel>
            {
                new OrderModel{ Id = 200, OrderDate = DateTime.Now.AddDays(-10), Reference = "CB-TTSS-001000", CustomerName = "Glenn Smith" },
                new OrderModel{ Id = 201, OrderDate = DateTime.Now.AddDays(-8), Reference = "CB-TTSS-001001", CustomerName = "John Smith" },
                new OrderModel{ Id = 202, OrderDate = DateTime.Now.AddDays(-7), Reference = "CB-TTSS-001002", CustomerName = "Kenn Smith" },
                new OrderModel{ Id = 203, OrderDate = DateTime.Now.AddDays(-6), Reference = "CB-TTSS-001003", CustomerName = "Karl Machium" },
                new OrderModel{ Id = 204, OrderDate = DateTime.Now.AddDays(-5), Reference = "CB-TTSS-001004", CustomerName = "Fiona Avery" },
            };
        }
    }
}
