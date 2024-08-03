using WebApplication_4.Entities;
using WebApplication_4.Repositories;

namespace WebApplication_4.Services
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public Task Create(Product product)
        {
            return _repository.Create(product);
        }

        public Task Delete(Product product)
        {
            return _repository.Delete(product);
        }

        public Task<Product?> GetProductByIdAsync(int id)
        {
            return _repository.GetProductById(id);
        }

        public Task<List<Product>> GetProductsAsync()
        {
            return _repository.GetProducts();
        }

        public Task Update(Product product)
        {
            return _repository.Update(product);
        }
    }
}
