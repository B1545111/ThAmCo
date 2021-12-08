using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Orders.Api.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Title { get; set; }

        public double Price { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}
