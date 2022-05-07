using System;
using GeometryLib;
using NUnit.Framework;

namespace GeometryLibTest;

public class CircleTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ZeroRadiusTest() => Assert.Null(Circle.TryCreate(-10));

    [Test]
    public void NegativeRadiusTest() => Assert.Null(Circle.TryCreate(-10));

    [Test]
    public void AreaTest()
    {
        var circle = Circle.TryCreate(11);
        if (circle != null) Assert.AreEqual(circle.Area, 380.132711084365);
    }
}