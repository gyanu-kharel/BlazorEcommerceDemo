using BlazorEcommerceDemo.Server.Models;
using BlazorEcommerceDemo.Shared.Models.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerceDemo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoriesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("")]
        public async Task<IActionResult> Get() =>
            Ok(await _dbContext.Categories.Select(x => new GetAllCategoriesDto(x.Id, x.Name, x.ImageUrl)).ToListAsync());
    }
}
