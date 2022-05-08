using GeometryLib.Interfaces;

namespace GeometryLib;

public class Circle : ICircle
{
    public double Radius { get; }
    public double Area => Math.PI * Math.Pow(Radius, 2);
    public static Circle? TryCreate(double radius) => radius <= 0 ? null : new Circle(radius);
    private Circle(double radius)
    {
        Radius = radius;
    }
}