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
        Assert.Null(Triangle.TryCreate(a,b,c));
    }
    
    [Test]
    public void NotTriangleTest()
    {
        Assert.Null(Triangle.TryCreate(1, 1, 4));
    }
    
    [Test]
    public void AreaTest()
    {
        var triangle = Triangle.TryCreate(3, 4, 5);
        if (triangle != null) Assert.AreEqual(triangle.Area, 6);
    }
    
    [TestCase(3, 4, 3, ExpectedResult = false)]
    [TestCase(3, 4, 5, ExpectedResult = true)]
    public bool NotRightTriangle(int a, int b, int c)
    {
        var triangle = Triangle.TryCreate(a, b, c);
        var isRight = triangle is {IsRightTriangle: true};
        return isRight;
    }
}