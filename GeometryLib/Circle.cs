using GeometryLib.Interfaces;

namespace GeometryLib;

public class Circle : ICircle
{
    private double? _radius;
    public double Radius
    {
        get
        {
            if (_radius != null) return (double) _radius;
            throw new ArgumentException("The radius was not set");
        }
        set
        {   
            if (value <= 0) throw new ArgumentException("The radius must be greater than 0");
            _radius = value;
        }
    }

    private double _area;
    public double Area
    {
        get
        {
            if (_area == 0) _area = Math.PI * Math.Pow(Radius, 2);
            return _area;
        }
    }

    public Circle(double radius)
    {
        Radius = radius;
    }
}