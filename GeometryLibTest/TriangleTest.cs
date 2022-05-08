using System;
using GeometryLib;
using NUnit.Framework;

namespace GeometryLibTest;

public class TriangleTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(-1, 1, 1)]
    [TestCase(1, -1, 1)]
    [TestCase(1, 1, -1)]
    [TestCase(0, 0, 0)]
    public void NegativeSideTest(int a, int b, int c)
    {
        Assert.IsFalse(Triangle.TryCreate(a, b, c, out _));
    }

    [Test]
    public void NotTriangleTest()
    {
        Assert.IsFalse(Triangle.TryCreate(1, 1, 4, out _));
    }

    [Test]
    public void AreaTest()
    {
        Triangle.TryCreate(3, 4, 5, out var triangle);
        Assert.AreEqual(triangle!.Area, 6);
    }

    [TestCase(3, 4, 3, ExpectedResult = false)]
    [TestCase(3, 4, 5, ExpectedResult = true)]
    public bool NotRightTriangle(int a, int b, int c)
    {
        Triangle.TryCreate(a, b, c, out var triangle);
        var isRight = triangle is {IsRightTriangle: true};
        return isRight;
    }
}