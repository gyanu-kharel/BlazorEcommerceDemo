using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerceDemo.Server.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var categories = new List<Category>()
            {
                new Category(){ Id = 1, Name = "Samsung" },
                new Category(){ Id = 2, Name = "Apple" },
                new Category(){ Id = 3, Name = "Sony" },
            };

            var products = new List<Product>()
            {
                new Product(){ Id = 1, Name = "Galaxy S22 Ultra", OriginalPrice = 1300, DiscountedPrice = 1199, CategoryId = 1 },
                new Product(){ Id = 2, Name = "Galaxy Fold 3", OriginalPrice = 1500, DiscountedPrice = 1500, CategoryId = 1 },
                new Product(){ Id = 3, Name = "Iphone 14 Pro", OriginalPrice = 1200, DiscountedPrice = 1099, CategoryId = 2 },
                new Product(){ Id = 4, Name = "Iphone 14 Pro Max", OriginalPrice = 1100, DiscountedPrice = 999, CategoryId = 2 },
                new Product(){ Id = 5, Name = "Sony Xperia Z1", OriginalPrice = 1600, DiscountedPrice = 1549, CategoryId = 3 },
            };

            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Product>().HasData(products);
            base.OnModelCreating(modelBuilder);
        }
    }
}
