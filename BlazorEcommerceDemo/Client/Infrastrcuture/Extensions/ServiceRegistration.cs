using BlazorEcommerceDemo.Client.Infrastrcuture.Services.Categories;
using BlazorEcommerceDemo.Client.Infrastrcuture.Services.Products;

namespace BlazorEcommerceDemo.Client.Infrastrcuture.Extensions
{
    public static class ServiceRegistration
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoriesService, CategoriesService>();
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
