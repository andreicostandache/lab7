using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer 
{
    public sealed class PoisContext : DbContext
    {
        public PoisContext(DbContextOptions<PoisContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Poi> Pois { get; set; }
    }
}
