#if (isNewFramework)
using FluentAssertions;
#endif
using Xunit;
using AutoMoxture.XUnit;

namespace xtestproj_legacy
{
    public class UnitTest1 : AutoMoxtureTest<object>
    {
        [Fact]
        public void Test1()
        {
#if (isNewFramework)
            Sut.Should().NotBeNull();
#else
            Assert.NotNull(Sut);
#endif
        }
    }
}