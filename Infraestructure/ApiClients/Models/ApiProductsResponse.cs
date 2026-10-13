using System;
using System.Collections.Generic;
using System.Text;

namespace InventarySystem.Infraestructure.ApiClients.Models
{
    public class ApiProductsResponse
    {
        /*
         * 
         * "id": 0,
            "title": "string",
            "price": 0.1,
            "description": "string",
            "category": "string",
            "image": "http://example.com"
         */
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
    }
}
