using HelloDocker.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloDocker.Web.Data
{
    public class DbInitializer
    {
        public static void Initialize(HelloDockerWebContext context)
        {
            context.Database.EnsureCreated();

            if (context.Products.Any())
            {
                return;
            }

            var products = new Product[]
            {
                new Product{Name="iphone 6",Price=5000,StockQty=10 },
                new Product{Name="iphone 7",Price=6000,StockQty=10 },
                new Product{Name="iphone 7 plus",Price=7000,StockQty=10 },
                new Product{Name="iphone x",Price=8000,StockQty=10 }
            };

            context.Products.AddRange(products);

            context.SaveChanges();
        }
    }
}
