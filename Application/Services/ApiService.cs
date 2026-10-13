using InventarySystem.Infraestructure.ApiClients;
using InventarySystem.Infraestructure.ApiClients.Models;
using System;
using System.Collections.Generic;
using System.Text;
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
            var data = new List<ApiProductsResponse>();

            try
            {
                var products = await ExternalApiClient.GetProducts();
                data = JsonSerializer.Deserialize<List<ApiProductsResponse>>(products, _jsonOptions);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return data ?? new List<ApiProductsResponse>();
        }
    }
}
