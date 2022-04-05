#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Old_Glory_Flag_Company.Models;

namespace Old_Glory_Flag_Company.Data
{
    public class Old_Glory_Flag_CompanyContext : DbContext
    {
        public Old_Glory_Flag_CompanyContext (DbContextOptions<Old_Glory_Flag_CompanyContext> options)
            : base(options)
        {
        }

        public DbSet<Old_Glory_Flag_Company.Models.Customer> Customer { get; set; }

        public DbSet<Old_Glory_Flag_Company.Models.Order> Order { get; set; }

        public DbSet<Old_Glory_Flag_Company.Models.Product> Product { get; set; }
    }
}
