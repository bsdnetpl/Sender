﻿using System.ComponentModel.DataAnnotations;

namespace Sender.DTO
{
    public class Customer
    {
        public Guid Id { get; set; }
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
        [MinLength(8)]
        public string Password { get; set; } = string.Empty;
        public DateTime dateTimeCreate { get; set; }
        public List<Box> Box { get; } = new();

    }
}
