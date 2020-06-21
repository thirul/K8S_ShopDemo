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
                new OrderModel{ Id = 200, OrderDate = DateTime.Now.AddDays(-10), CustomerId = 100, OrderReference = Guid.NewGuid().ToString()},
                new OrderModel{ Id = 201, OrderDate = DateTime.Now.AddDays(-5), CustomerId = 101, OrderReference = Guid.NewGuid().ToString()},
                new OrderModel{ Id = 202, OrderDate = DateTime.Now.AddDays(-15), CustomerId = 102, OrderReference = Guid.NewGuid().ToString()},


            };
        }
    }
}

