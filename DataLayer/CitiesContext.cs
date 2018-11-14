using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public sealed class CitiesContext : DbContext
    {
        public CitiesContext(DbContextOptions<CitiesContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<City> Cities { get; set; }
    }
}
