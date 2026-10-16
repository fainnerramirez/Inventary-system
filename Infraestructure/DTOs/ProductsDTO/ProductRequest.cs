using System;
using System.Collections.Generic;
using System.Text;

namespace InventarySystem.Infraestructure.DTOs.ProductsDTO
{
    public class ProductRequest
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public decimal ProductPrice { get; set; } = 0;
        public int ProductStock { get; set; } = 0;
        public string ProductCategory { get; set; } = string.Empty;
        public DateTime ProductCreatedAt { get; set; }
        public DateTime ProductUpdatedAt { get; set; }
        public string ProductUpdateAtDisplay => ProductUpdatedAt == DateTime.MinValue ? "N/A" : ProductUpdatedAt.ToString();
    }
}