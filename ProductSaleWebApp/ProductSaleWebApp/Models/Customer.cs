using System.ComponentModel.DataAnnotations;

namespace ProductSaleWebApp.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The {0} field is obligatory")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size must be between {2} and {1} characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The {0} field is obligatory")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The {0} field is obligatory")]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        public ICollection<PurchasesRecord> Purchases { get; set; } = new List<PurchasesRecord>();

        public Customer()
        {
        }

        public Customer(int id, string name, string email, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public void AddCustomer(PurchasesRecord purchase)
        {
            Purchases.Add(purchase);
        }
    }
}
