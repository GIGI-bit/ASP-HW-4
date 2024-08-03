using Microsoft.EntityFrameworkCore;
using WebApplication_4.Entities;

namespace WebApplication_4.Data
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext>options):base(options)
        {
            
        }

        public DbSet<Category>Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
