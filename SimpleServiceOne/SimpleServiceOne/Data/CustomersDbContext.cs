using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleServiceOne.Models;

namespace SimpleServiceOne.Data
{
    public class CustomersDbContext : DbContext
    {
        public CustomersDbContext (DbContextOptions<CustomersDbContext> options)
            : base(options)
        {
        }

        public DbSet<SimpleServiceOne.Models.Customer> Customer { get; set; } = default!;
    }
}
