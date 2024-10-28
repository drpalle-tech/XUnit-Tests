using Moq;
using Xunit;

namespace XUnitTestingApp
{
    public class MoqDependenciesOfClass
    {

        [Fact]
        public void GetCombinedData_ShouldReturnCombinedString()
        {
            // Create a mock for the IExternalService
            var mockExternalService = new Mock<IExternalService>();

            // Configure the mock to return specific data for the GetData method
            mockExternalService.Setup(service => service.GetData(It.IsAny<string>()))
                .Returns("Speakers");

            // Create the MyService instance with the mock object
            var myService = new MyService(mockExternalService.Object);

            // Call the method under test
            var result = myService.GetCombinedData("Bose");

            // Assert the expected result
            Assert.Equal("Bose - Speakers", result);
        }
    }

    public interface IExternalService
    {
        string GetData(string name);
    }

    public class MyService
    {
        private readonly IExternalService _externalService;

        public MyService(IExternalService externalService)
        {
            _externalService = externalService;
        }

        public string GetCombinedData(string name)
        {
            var externalData = _externalService.GetData(name);
            return $"{name} - {externalData}";
        }
    }

}
