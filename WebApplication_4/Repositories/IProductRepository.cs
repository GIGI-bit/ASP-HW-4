using WebApplication_4.Entities;

namespace WebApplication_4.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();
        Task<Product?> GetProductById(int id);

        Task Create(Product product);
        Task Update(Product product);
        Task Delete(Product product);

    }
}
