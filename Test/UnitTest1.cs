using Moq;
using Sender.Controllers;
using Sender.DTO;
using Sender.Services;
using Xunit;
using TheoryAttribute = Xunit.TheoryAttribute;

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

            Assert.That(result, Is.True);
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
        [Theory]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(11)]
        public void GenerateCodePickupLenght(int length)
        {
            Boxes boxee = new Boxes();
           var result = boxee.GenerateCodePickup(length);
            
            Assert.Equals(length, result.Length);

        }
    }



}