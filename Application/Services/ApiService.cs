using InventarySystem.Infraestructure.ApiClients;
using InventarySystem.Infraestructure.ApiClients.Models;
using System;
using System.Text.Json;

namespace InventarySystem.Application.Services
{
    public static class ApiService
    {
        private static readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public async static Task<List<ApiProductsResponse>> GetProducts()
        {
            var products = await ExternalApiClient.GetProducts();
            var data = JsonSerializer.Deserialize<List<ApiProductsResponse>>(products, _jsonOptions);
            return data ?? new List<ApiProductsResponse>();
        }
    }
}
