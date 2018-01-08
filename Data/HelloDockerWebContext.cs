using Docker.NetCore.MySql.Models;
using Microsoft.EntityFrameworkCore;

namespace Docker.NetCore.MySql.Data
{
    public class HelloDockerWebContext : DbContext
    {
        public HelloDockerWebContext (DbContextOptions<HelloDockerWebContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
