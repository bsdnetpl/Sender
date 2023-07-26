using Sender.DTO;

namespace Sender.Services
{
    public interface ICustomer
    {
        List<Customer> GetCustomer(string Name);
       bool AddCustomer(CustomerDTO customerDTO);
    }
}
