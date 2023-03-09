using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HumanResourceManagerment;

namespace HumanResourceManagerment.Data
{
    public class HumanResourceManagermentContext : DbContext
    {
        public HumanResourceManagermentContext (DbContextOptions<HumanResourceManagermentContext> options)
            : base(options)
        {
        }

        public DbSet<HumanResourceManagerment.Employee> Employee { get; set; } = default!;
    }
}
