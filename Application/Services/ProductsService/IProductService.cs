using InventarySystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventarySystem.Application.Services.ProductsService
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
    }
}