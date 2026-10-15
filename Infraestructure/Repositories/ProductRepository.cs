using Dapper;
using InventarySystem.Domain.Entities;
using InventarySystem.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventarySystem.Infraestructure.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly IDbConnectionFactory _factory;
        public ProductRepository(IDbConnectionFactory factory) => _factory = factory;

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            using var connection = await _factory.CreateOpenConnectionAsync();
            var sql = "SELECT * FROM Products";
            var products = await connection.QueryAsync<Product>(sql);
            return products;
        }
    }
}