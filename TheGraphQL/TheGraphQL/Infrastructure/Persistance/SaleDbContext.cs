using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TheGraphQL.Domain;

namespace TheGraphQL.Infrastructure.Persistance
{
    public class SaleDbContext : DbContext
    {
        public SaleDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Seed();
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
    }
}
