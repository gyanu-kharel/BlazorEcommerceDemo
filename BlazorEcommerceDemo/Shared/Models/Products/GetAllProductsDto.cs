namespace BlazorEcommerceDemo.Shared.Models.Products
{
    public record GetAllProductsDto(
        int Id,
        string Name,
        decimal OriginalPrice,
        decimal? DiscountPrice,
        string CategoryName
        );
}
