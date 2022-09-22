using FluentAssertions;
using Xunit;
using AutoMoxture.XUnit;

namespace xtestproj
{
    public class UnitTest1 : AutoMoxtureTest<object>
    {
        [Fact]
        public void Test1()
        {
            Sut.Should().NotBeNull();
        }
    }
}