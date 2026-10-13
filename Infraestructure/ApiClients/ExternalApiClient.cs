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
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, BaseUrl);
                var response = await _httpClient.SendAsync(request);
                var data = await response.Content.ReadAsStringAsync();
                return data;
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"HTTP error occurred: {httpEx.Message}");
            }
            catch (JsonException jsonEx)
            {
                MessageBox.Show($"JSON error occurred: {jsonEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error making request to {BaseUrl}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return string.Empty;
        }
    }
}