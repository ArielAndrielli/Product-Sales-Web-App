using ProductSaleWebApp.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProductSaleWebApp.Models
{
    public class PurchasesRecord
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Amount { get; set; }
        public PurchaseStatus Status { get; set; }
        public Customer Customer { get; set; }

        public PurchasesRecord()
        {
        }

        public PurchasesRecord(int id, DateTime date, double amount, PurchaseStatus status, Customer customer)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Customer = customer;
        }
    }
}
