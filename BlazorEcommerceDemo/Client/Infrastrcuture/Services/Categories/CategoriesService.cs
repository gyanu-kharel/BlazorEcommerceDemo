using BlazorEcommerceDemo.Shared.Models.Categories;
using System.Net.Http.Json;

namespace BlazorEcommerceDemo.Client.Infrastrcuture.Services.Categories
{
    public class CategoriesService : ICategoriesService
    {
        private readonly HttpClient _httpClient;
        private const string path = "api/categories";
        public CategoriesService(HttpClient httpClient) => _httpClient = httpClient;
        public async Task<IEnumerable<GetAllCategoriesDto>> GetAllCategoriesAsync()
            => await _httpClient.GetFromJsonAsync<IEnumerable<GetAllCategoriesDto>>(path);
    }
}
