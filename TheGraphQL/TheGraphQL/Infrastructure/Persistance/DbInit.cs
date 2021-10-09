using Microsoft.EntityFrameworkCore;
using TheGraphQL.Domain;

namespace TheGraphQL.Infrastructure.Persistance
{
    public static class DbInit
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory
                {
                    Id = 1,
                    Name = "Book"
                }
            );
            modelBuilder.Entity<Product>().HasData(
               new Product
               {
                   Id = 1,
                   Name = "Clean Code",
                   CategoryId = 1
               }
           );
        }

    }
}
