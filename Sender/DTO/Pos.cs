using System.ComponentModel.DataAnnotations;

namespace Sender.DTO
{
    public class Pos
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateTimeCreate { get; set; }
        public DateTime DatadateOfReceipt { get; set; }
        public double CommissionBrutto { get; set; }
        public double CommissionNetto { get; set; }
        public double VatTax { get; set; }
        public string NIP { get; set; }
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        [MinLength(8)]
        public string Password { get; set; } = string.Empty;
        public List<Box> Box { get; } = new();
    }
}
