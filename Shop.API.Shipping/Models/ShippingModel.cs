using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.API.Product.Models
{
    public class ShippingModel
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime ShippingDate { get; set; }
        public string Address { get; set; }
    }
}
