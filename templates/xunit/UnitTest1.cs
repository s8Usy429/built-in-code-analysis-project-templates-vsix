// <copyright file="UnitTest1.cs" company="MyCompanyName">
// Copyright (c) MyCompanyName. All rights reserved.
// </copyright>

namespace xtestproj;

using AutoMoxture.XUnit;

using FluentAssertions;

using Xunit;

public class UnitTest1 : AutoMoxtureTest<object>
{
    [Fact]
    public void Test1()
    {
        this.Sut.Should().NotBeNull();
    }
}
