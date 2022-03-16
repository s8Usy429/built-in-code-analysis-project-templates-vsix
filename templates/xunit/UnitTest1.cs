using FluentAssertions;
using Xunit;

namespace xtestproj
{
    public class UnitTest1 : BaseTest<object>
    {
        [Fact]
        public void Test1()
        {
            Sut.Should().NotBeNull();
        }
    }
}