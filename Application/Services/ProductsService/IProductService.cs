using InventarySystem.Domain.Entities;
using InventarySystem.Infraestructure.DTOs.ProductsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventarySystem.Application.Services.ProductsService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductResponse>> GetAllProductsAsync();
    }
}