using Xunit;

namespace XUnitTestingApp
{
    /// <summary>
    /// Asserts collection
    /// </summary>
    public class CollectionsTests
    {

        public List<int> EvenList = [0,2,4,6,8];


        [Fact]
        public void EventListDoesNotIncludeOddNumber()
        {
            Assert.All(EvenList, x => Assert.NotEqual(1, x));
        }

        [Fact]
        public void EventListIncludes8()
        {
            Assert.Contains(8, EvenList);
        }

        [Fact]
        public void EventListDoesNotIncludes5()
        {
            Assert.DoesNotContain(5, EvenList);
        }

    }
}
