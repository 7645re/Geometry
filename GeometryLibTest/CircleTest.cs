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
    public void ZeroRadiusTest() => Assert.IsFalse(Circle.TryCreate(0, out var _));

    [Test]
    public void NegativeRadiusTest() => Assert.IsFalse(Circle.TryCreate(-10, out var _));

    [Test]
    public void AreaTest()
    {
        Circle.TryCreate(11, out var circle);
        if (circle != null) Assert.AreEqual(circle.Area, 380.132711084365);
    }
}