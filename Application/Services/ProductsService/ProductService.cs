using InventarySystem.Domain.Entities;
using InventarySystem.Infraestructure.Repositories;

namespace InventarySystem.Application.Services.ProductsService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo) => _repo = repo;

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _repo.GetAllProductsAsync();
        }
    }
}