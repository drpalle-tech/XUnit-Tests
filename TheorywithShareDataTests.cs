using Xunit;

namespace XUnitTestingApp
{
    public class TheorywithShareDataTests
    {
        [Theory]
        [MemberData(nameof(TestDataShare.IsOddorEventData), MemberType = typeof(TestDataShare))]
        public void TheorywithShareData_IsOddOrNot(int val, bool expectedResult)
        {
            Assert.Equal(expectedResult, CheckOddNumber(val));
        }

        public bool CheckOddNumber(int val)
        {
            return val % 2 != 0;
        }
    }
}
