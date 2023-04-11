using BlazorEcommerceDemo.Shared.Models.Products;

namespace BlazorEcommerceDemo.Client.Infrastrcuture.Services.Products
{
    public interface IProductService
    {
        Task<IEnumerable<GetAllProductsDto>> GetAllProductsAsync();
    }
}
