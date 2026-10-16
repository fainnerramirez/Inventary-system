using System;
using System.Collections.Generic;
using System.Text;

namespace InventarySystem.Domain.Entities
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0;
        public int Stock { get; set; } = 0;
        public string Category { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}