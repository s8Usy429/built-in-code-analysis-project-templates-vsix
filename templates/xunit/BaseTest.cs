using AutoFixture;
using AutoFixture.AutoMoq;
using System;

namespace xtestproj
{
    public abstract class BaseTest<TSut>
    {
        private readonly Lazy<TSut> _lazySut;
 
        protected TSut Sut => _lazySut.Value;
 
        protected IFixture Fixture { get; }

        protected BaseTest()
        {
            Fixture = new Fixture().Customize(new AutoMoqCustomization());
            _lazySut = new Lazy<TSut>(() => Fixture.Create<TSut>());
        }
    }
}