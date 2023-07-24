namespace Sender.DTO
{
    public class ConsignorDTO
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string NIP { get; set; } = string.Empty;
        public double priceNetto { get; set; }
        public double priceBrutto { get; set; }
        public double VatTax { get; set; }
        public string Password { get; set; } = string.Empty;
    }
}
