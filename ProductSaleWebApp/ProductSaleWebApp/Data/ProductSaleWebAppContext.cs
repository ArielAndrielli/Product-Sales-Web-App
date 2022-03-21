using Microsoft.EntityFrameworkCore;


namespace ProductSaleWebApp.Models
{
    public class ProductSaleWebAppContext : DbContext
    {
        public ProductSaleWebAppContext(DbContextOptions<ProductSaleWebAppContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PurchasesRecord> Purchases { get; set; }

    }
}
