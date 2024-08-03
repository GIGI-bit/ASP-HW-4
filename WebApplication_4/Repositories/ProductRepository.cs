using WebApplication_4.Data;
using WebApplication_4.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApplication_4.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private readonly ProductDbContext _context;

        public ProductRepository(ProductDbContext context)
        {
            _context = context;
        }

        public async Task Create(Product product)
        {
            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Product product)
        {
            _context.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<Product?> GetProductById(int id)
        {
            return await _context.Products.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Product>> GetProducts()
        {

            return await _context.Products.ToListAsync();
        }

        public async Task Update(Product product)
        {
            _context.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
