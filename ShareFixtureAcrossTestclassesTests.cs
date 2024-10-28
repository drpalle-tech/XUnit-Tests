using Xunit;

namespace XUnitTestingApp
{
    public class ShareFixtureAcrossTestclassesTests
    {
        /* 
             Code descriptoin:

            The SharedResourceFixture class holds the shared resource(Resource) for all tests in the collection.

            The SharedResourceCollection class defines the collection and provides the shared resource fixture through 
            its implementation of ICollectionFixture<SharedResourceFixture>.

            Test classes with the[Collection] attribute and the corresponding collection name("SharedResourceCollection") 
            will receive the shared resource fixture through their constructor.

             This allows tests within the same collection to access and potentially modify the shared resource.
 
            Advantage:

            Shared setup and teardown: The fixture can handle resource initialization and cleanup, reducing code duplication in individual tests.

            Data isolation: Each collection runs in its own isolated environment, preventing tests from interfering with each other's data.
         */
    }

    public class SharedResourceFixture
    {
        public int Resource { get; set; }

        public SharedResourceFixture()
        {
            Resource = 10; 
        }
    }

    [CollectionDefinition("SharedResourceCollection")]
    public class SharedResourceCollection : ICollectionFixture<SharedResourceFixture>
    {
    }

    [Collection("SharedResourceCollection")]
    public class TestClass1
    {
        private readonly SharedResourceFixture _fixture;

        public TestClass1(SharedResourceFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Test1()
        {
            Assert.Equal(10, _fixture.Resource);
        }
    }

    [Collection("SharedResourceCollection")]
    public class TestClass2
    {
        private readonly SharedResourceFixture _fixture;

        public TestClass2(SharedResourceFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Test2()
        {
           Assert.NotEqual(11, _fixture.Resource);
        }
    }


}
