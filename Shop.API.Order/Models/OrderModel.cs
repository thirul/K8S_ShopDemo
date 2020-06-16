using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.API.Order.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public DateTime OrderDate  { get; set; }

        public string CustomerName { get; set; }
    }
}
