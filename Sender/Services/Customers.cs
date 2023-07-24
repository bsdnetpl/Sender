using Sender.DB;
using Sender.DTO;

namespace Sender.Services
{
    public class Customers : ICustomer
    {
        private readonly ConnectMssql _connectMssql;

        public Customers(ConnectMssql connectMssql)
        {
            _connectMssql = connectMssql;
        }

        public bool AddCustomer(CustomerDTO customerDTO)
        {
            Customer customer = new Customer();
            customer.Id = Guid.NewGuid();
            customer.dateTimeCreate = DateTime.Now;
            customer.FirstName = customerDTO.FirstName;
            customer.LastName = customerDTO.LastName;
            customer.Address = customerDTO.Address;
            customer.City = customerDTO.City;
            customer.Region = customerDTO.Region;
            customer.PostalCode = customerDTO.PostalCode;
            customer.Country = customerDTO.Country;
            customer.Phone = customerDTO.Phone;
            customer.Name = customerDTO.Name;
            customer.email = customerDTO.email;
            _connectMssql.customers.Add(customer);
            _connectMssql.SaveChanges();
            return true;
        }

        public Guid GetCustomer(string Name)
        {
            throw new NotImplementedException();
        }
    }
}
