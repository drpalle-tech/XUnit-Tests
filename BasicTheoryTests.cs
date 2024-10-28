using Xunit;

namespace XUnitTestingApp
{
    public class BasicTheoryTests
    {
        [Theory]
        [InlineData(3,true)]
        [InlineData(5,true)]
        [InlineData(7,true)]
        [InlineData(8,false)]
        public void GivenNumber_IsOddOrNot(int val, bool expectedResult)
        {
            Assert.Equal(expectedResult, CheckOddNumber(val));
        }

        public bool CheckOddNumber(int val) { 
            return val % 2 != 0;
       }
    }
}
