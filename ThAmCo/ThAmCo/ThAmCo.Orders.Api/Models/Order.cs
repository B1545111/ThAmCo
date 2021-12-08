using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Orders.Api.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public List<Product> Products { get; set; }

        public double Total 
        {
            get { return Products.Sum(p => p.Price); }
        }
    }
}
