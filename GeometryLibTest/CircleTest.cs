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
    public void ZeroRadiusTest()
    {
        Assert.Catch<ArgumentException>(() =>
        {
            var circle = new Circle(0);
        });
    }


    [Test]
    public void NegativeRadiusTest()
    {
        Assert.Catch<ArgumentException>(() =>
        {
            var circle = new Circle(-10);
        });
    }

    [Test]
    public void AreaTest()
    {
        var circle = new Circle(11);
        Assert.AreEqual(circle.Area, 380.132711084365);
    }
}