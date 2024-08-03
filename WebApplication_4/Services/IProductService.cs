using WebApplication_4.Entities;

namespace WebApplication_4.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync();
        Task<Product?> GetProductByIdAsync(int id);

        Task Create(Product product);
        Task Update(Product product);
        Task Delete(Product product);
    }
}
