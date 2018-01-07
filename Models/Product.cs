using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloDocker.Web.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQty { get; set; }
    }
}
