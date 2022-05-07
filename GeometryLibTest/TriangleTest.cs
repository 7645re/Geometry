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
    public void NegativeSideTest(double a, double b, double c)
    {
        Assert.Catch<ArgumentException>(() =>
        {
            var triangle = new Triangle(a,b,c);
        });
    }
    
    [Test]
    public void NotTriangleTest()
    {
        Assert.Catch<ArgumentException>(() =>
        {
            var triangle = new Triangle(1, 1, 4);
        });
    }
    
    [Test]
    public void AreaTest()
    {
        var triangle = new Triangle(3,4,5);
        Assert.AreEqual(triangle.Area, 6);
    }
    
    [TestCase(3, 4, 3, ExpectedResult = false)]
    [TestCase(3, 4, 5, ExpectedResult = true)]
    [TestCase(3, 4, 5.000000001, ExpectedResult = true)]
    public bool NotRightTriangle(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        var isRight = triangle.IsRightTriangle;
        return isRight;
    }
}