using InventarySystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventarySystem.Infraestructure.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
    }
}