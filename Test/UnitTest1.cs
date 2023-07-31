using Moq;
using Sender.Controllers;
using Sender.DTO;
using Sender.Services;

namespace Test
{
    public class Tests
    {

        [Test]
        public void AddCustomerShouldReturnTrue()
        {
            var mocAddCustomer = new Mock<ICustomer>();
            mocAddCustomer.Setup(x => x.AddCustomer(It.IsAny<CustomerDTO>())).Returns(true);
            var CustomerClass = new CustomerController(mocAddCustomer.Object);
            var result = CustomerClass.AddCustomer(It.IsAny<CustomerDTO>());

            Assert.That(result,Is.True);
        }
        [Test]
        public void AddCustomerShouldReturnFalse()
        {
            var mocAddCustomer = new Mock<ICustomer>();
            mocAddCustomer.Setup(x => x.AddCustomer(It.IsAny<CustomerDTO>())).Returns(false);
            var CustomerClass = new CustomerController(mocAddCustomer.Object);
            var result = CustomerClass.AddCustomer(It.IsAny<CustomerDTO>());

            Assert.That(result, Is.False);
        }
    }
}