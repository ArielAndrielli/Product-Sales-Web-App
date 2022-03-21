using ProductSaleWebApp.Models;
using ProductSaleWebApp.Models.Enums;

namespace ProductSaleWebApp.Data
{
    public class SeedingService
    {
        private ProductSaleWebAppContext _context;

        public SeedingService(ProductSaleWebAppContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Categories.Any() || 
                _context.Customers.Any() || 
                _context.Purchases.Any())
            {
                return; // DB has been seeded
            }

            Category c1 = new Category(1, "Motherboards");
            Category c2 = new Category(2, "Processors");
            Category c3 = new Category(3, "R.A.M");
            Category c4 = new Category(4, "Monitors");
            Category c5 = new Category(5, "Graphic Cards");

            Customer customer1 = new Customer(1, "Robert Lawrence", "roblaw@gmail.com", new DateTime(1987, 06, 07));
            Customer customer2 = new Customer(2, "Aubrey Harley", "aubrey@gmail.com", new DateTime(2002, 10, 07));
            Customer customer3 = new Customer(3, "Kel Kyama", "kelloghs@gmail.com", new DateTime(2002, 12, 07));
            Customer customer4 = new Customer(4, "Hero Kamado", "hero@gmail.com", new DateTime(2000, 09, 07));
            Customer customer5 = new Customer(5, "Oliver Twist", "orphan@gmail.com", new DateTime(2006, 08, 07));
            Customer customer6 = new Customer(6, "Omori Shirou", "omori@gmail.com", new DateTime(1999, 01, 07));
            Customer customer7 = new Customer(7, "Lilla Freeman", "lilla@gmail.com", new DateTime(1998, 03, 07));
            Customer customer8 = new Customer(8, "Hannah Montanna", "hamon@gmail.com", new DateTime(1985, 11, 07));
            Customer customer9 = new Customer(9, "Loric Derping", "loric@gmail.com", new DateTime(2010, 11, 07));
            Customer customer10 = new Customer(10, "Grace Oscar", "graceoscar@gmail.com", new DateTime(2005, 10, 07));
            Customer customer11 = new Customer(11, "Lisa Jude", "lisa@gmail.com", new DateTime(2000, 02, 07));
            Customer customer12 = new Customer(12, "James Baxter", "horse@gmail.com", new DateTime(1980, 06, 07));
            Customer customer13 = new Customer(13, "Delilah Ace", "reyna@gmail.com", new DateTime(1950, 05, 07));
            Customer customer14 = new Customer(14, "Gregory Kai", "gregory@gmail.com", new DateTime(2015, 01, 07));

            PurchasesRecord pr1 = new PurchasesRecord(1, new DateTime(2018, 09, 25), 11000.0, PurchaseStatus.Billed, c1);

            _context.Categories.AddRange(c1, c2, c3, c4);

            _context.Customers.AddRange(
                customer1, customer2, customer3, customer4, customer5, customer6, customer7,
                customer8, customer9, customer10, customer11, customer12, customer13, customer14
                );

            _context.Purchases.AddRange();

            _context.SaveChanges();

        }
    }
}
