using BlazorEcommerceDemo.Shared.Models.Categories;

namespace BlazorEcommerceDemo.Client.Infrastrcuture.Services.Categories
{
    public interface ICategoriesService
    {
        Task<IEnumerable<GetAllCategoriesDto>> GetAllCategoriesAsync();
    }
}
