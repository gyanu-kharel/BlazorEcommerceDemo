using BlazorEcommerceDemo.Shared.Models.Products;
using System.Net.Http.Json;

namespace BlazorEcommerceDemo.Client.Infrastrcuture.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private const string path = "api/products";
        public ProductService(HttpClient httpClient)
            => _httpClient = httpClient;
        public async Task<IEnumerable<GetAllProductsDto>> GetAllProductsAsync()
            => await _httpClient.GetFromJsonAsync<IEnumerable<GetAllProductsDto>>(path);
    }
}
