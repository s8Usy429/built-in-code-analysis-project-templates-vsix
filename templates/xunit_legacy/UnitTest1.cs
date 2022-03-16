#if (isNewFramework)
using FluentAssertions;
#endif
using Xunit;

namespace xtestproj_legacy
{
    public class UnitTest1 : BaseTest<object>
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