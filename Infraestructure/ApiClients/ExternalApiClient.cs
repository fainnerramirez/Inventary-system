using InventarySystem.Infraestructure.ApiClients.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace InventarySystem.Infraestructure.ApiClients
{
    public static class ExternalApiClient
    {
        public static string BaseUrl = "https://fakestoreapi.com/products";
        private static readonly HttpClient _httpClient = new();
            
        public async static Task<string> GetProducts()
        {         
            var request = new HttpRequestMessage(HttpMethod.Get, BaseUrl);
            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return data;
        }
    }
}