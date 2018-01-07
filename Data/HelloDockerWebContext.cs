using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HelloDocker.Web.Models;

namespace HelloDocker.Web.Data
{
    public class HelloDockerWebContext : DbContext
    {
        public HelloDockerWebContext (DbContextOptions<HelloDockerWebContext> options)
            : base(options)
        {
        }

        public DbSet<HelloDocker.Web.Models.Product> Products { get; set; }
    }
}
