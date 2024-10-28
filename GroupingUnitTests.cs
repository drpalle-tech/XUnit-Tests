using Xunit;

namespace XUnitTestingApp
{
    public class GroupingUnitTests
    {
        [Fact]
        [Trait("Category", "Numbers")]
        public void GivenNumberIsOddOrNot()
        {
            Assert.True(CheckOddNumber(3));
        }

        [Fact]
        [Trait("Category", "Numbers")]
        public void AddInt_GivenTwoIntValues_ReturnsInt()
        {
            Assert.Equal(5, AddTwoNumbers(2, 3));
        }

        public int AddTwoNumbers(int a, int b) { return a + b; }
        public bool CheckOddNumber(int val)
        {
            return val % 2 != 0;
        }
    }
}
