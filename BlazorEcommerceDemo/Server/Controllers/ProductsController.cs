using BlazorEcommerceDemo.Server.Models;
using BlazorEcommerceDemo.Shared.Models.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerceDemo.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductsController(ApplicationDbContext dbContext) => _dbContext = dbContext;

        [HttpGet("")]
        public async Task<IActionResult> Get()
            => Ok(await _dbContext.Products.Select(x => new GetAllProductsDto(
                    x.Id,
                    x.Name,
                    x.OriginalPrice,
                    x.DiscountedPrice,
                    x.Category.Name
                )).ToListAsync());
    }
}
