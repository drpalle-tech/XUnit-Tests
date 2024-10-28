using Xunit;
using Xunit.Abstractions;

namespace XUnitTestingApp
{

    public class ConsumerFixture
    {
        public Consumer consumer = new Consumer();
    }

    public class FixturesTests : IClassFixture<ConsumerFixture>
    {
        private readonly Consumer _consumer;
        private readonly ITestOutputHelper _testOutputHelper;

        public FixturesTests(ConsumerFixture _consumerFixture, ITestOutputHelper _testOutputHelper)
        {
            _consumer = _consumerFixture.consumer;
            _testOutputHelper.WriteLine("Constructor");
        }

        [Fact]
        public void TestCustomerOderException()
        {
            _consumer.Name = "Marco";
            _consumer.Age = 30;
            _consumer.OrderId = 0;
            Assert.Throws<ArgumentException>(() => _consumer.GetOrderNumber(_consumer.OrderId));
            Assert.Equal("Wrong order id", (Assert.Throws<ArgumentException>(() => _consumer.GetOrderNumber(_consumer.OrderId))).Message);
        }

        [Fact]
        public void ValidateCustomerAge()
        {
            Assert.InRange(_consumer.Age, 20, 40);
        }
    }

    public class Consumer
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
