using InventarySystem.Domain.Entities;
using InventarySystem.Infraestructure.DTOs.ProductsDTO;
using InventarySystem.Infraestructure.Repositories;

namespace InventarySystem.Application.Services.ProductsService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo) => _repo = repo;

        public async Task<IEnumerable<ProductResponse>> GetAllProductsAsync()
        {
            var products = await _repo.GetAllProductsAsync();
            return products.Select(p => new ProductResponse
            {
                ProductId = p.Id,
                ProductName = p.Name,
                ProductDescription = p.Description,
                ProductPrice = p.Price,
                ProductStock = p.Stock,
                ProductCategory = p.Category,
                ProductCreatedAt = p.CreatedAt,
                ProductUpdatedAt = p.UpdatedAt
            });
        }
    }
}