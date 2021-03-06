﻿using Microsoft.AspNetCore.Mvc;
using Shop.API.Order.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.API.Order.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private OrderContext _orderContext;
        public OrderController(OrderContext orderContext)
        {
            this._orderContext = orderContext;
        }

        public async Task<IEnumerable<OrderModel>> Get() {

            return _orderContext.Orders.ToList();
        }

        [Route("keys")]
        public async Task<string> GetKeys()
        {
            var hostname = Environment.GetEnvironmentVariable("docker_sql") ?? "this is hardcord value-sql";
            var password = Environment.GetEnvironmentVariable("docker_pwd") ?? "this is hardcord value-pwd";
            return $"reading values sql= {hostname} and password = {password}";
        }
    }
}
