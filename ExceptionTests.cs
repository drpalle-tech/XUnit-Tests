using Xunit;

namespace XUnitTestingApp
{
    public class ExceptionTests
    {
        public Customer _customer { get; set; }

        public ExceptionTests() {
            _customer = new Customer();
        }

        [Fact]
        public void TestCustomerOderException() {
            _customer.Name = "Marco";
            _customer.Age = 30;
            _customer.OrderId = 0;
            Assert.Throws<ArgumentException>(() => _customer.GetOrderNumber(_customer.OrderId));
            Assert.Equal("Wrong order id", (Assert.Throws<ArgumentException>(() => _customer.GetOrderNumber(_customer.OrderId))).Message);
        }


        [Fact]
        public void ValidateCustomerAge()
        {
            Assert.InRange(_customer.Age, 20, 40);
        }

    }

    public class Customer
    { 
        public string Name { get; set; }
        public int Age { get; set; } = 25;
        public int OrderId { get; set; }

        public string GetOrderNumber(int OrderId)
        {
            if (OrderId == 0)
            {
                throw new ArgumentException("Wrong order id");
            }
            return OrderId.ToString();

        }
    }
}
