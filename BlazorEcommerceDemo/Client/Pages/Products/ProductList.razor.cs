using BlazorEcommerceDemo.Shared.Models.Products;

namespace BlazorEcommerceDemo.Client.Pages.Products
{
    public partial class ProductList
    {
        private IEnumerable<GetAllProductsDto> products;

        protected override async Task OnInitializedAsync()
        {
            products = await ProductService.GetAllProductsAsync();
        }
    }
}
