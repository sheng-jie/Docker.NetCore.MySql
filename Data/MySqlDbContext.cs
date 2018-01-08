using Docker.NetCore.MySql.Models;
using Microsoft.EntityFrameworkCore;

namespace Docker.NetCore.MySql.Data
{
    public class MySqlDbContext : DbContext
    {
        public MySqlDbContext (DbContextOptions<MySqlDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
