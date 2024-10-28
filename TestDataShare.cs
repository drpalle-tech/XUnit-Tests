namespace XUnitTestingApp
{
    public class TestDataShare
    {

        public static IEnumerable<object[]> IsOddorEventData { 
            get {
                yield return new object[] { 1, true };
                yield return new object[] { 2, false };
            } 
        }
    }
}
