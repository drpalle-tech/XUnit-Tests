using Xunit;

namespace XUnitTestingApp
{
    public class BasicFactTests
    {
        [Fact] 
        public void BasicFactTest()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public void AddInt_GivenTwoIntValues_ReturnsInt()
        {
            Assert.Equal(5, AddTwoNumbers(2,3));
        }

        public int AddTwoNumbers(int a, int b) {  return a + b; }
    }
}
