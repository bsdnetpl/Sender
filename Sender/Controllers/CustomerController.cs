using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sender.DTO;
using Sender.Services;

namespace Sender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomer _customer;

        public CustomerController(ICustomer customer)
        {
            _customer = customer;
        }

        [HttpGet("GetCustomer")]
        public ActionResult<Customer> GetCustomer(string Name)
        {
            return Ok(_customer.GetCustomer(Name));
        }
        [HttpPost("AddCustomer")]
        public ActionResult<CustomerDTO>AddCustomer(CustomerDTO customerDTO)
        {
            _customer.AddCustomer(customerDTO);
            return Ok(customerDTO);
        }
    }
}
