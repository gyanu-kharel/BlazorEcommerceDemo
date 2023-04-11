using System.ComponentModel.DataAnnotations;

namespace BlazorEcommerceDemo.Shared.Models.Products
{
    public class EditProductRequestDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Minimum length is 5")]
        [MaxLength(20, ErrorMessage ="Maximum length is 20")]
        public string Name { get; set; }

        [Required]
        public decimal OriginalPrice { get; set; }

        public decimal? DiscountedPrice { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public string? ImageURL { get; set; }


    }
}
