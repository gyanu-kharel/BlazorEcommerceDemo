namespace BlazorEcommerceDemo.Server.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal? DiscountedPrice { get; set; }
        public string? ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
