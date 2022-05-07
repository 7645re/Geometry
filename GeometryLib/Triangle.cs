using System.Reflection.Metadata.Ecma335;
using GeometryLib.Interfaces;

namespace GeometryLib;

public class Triangle : ITriangle
{
    private bool? _isRightTriangle;
    public bool IsRightTriangle {
        get
        {
            if (_isRightTriangle != null) return (bool) _isRightTriangle;
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);
            _isRightTriangle = (int) Math.Pow(sides[2], 2) == (int) (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2));
            return (bool) _isRightTriangle;
        }
    }
    private double _area;
    public double Area
    {
        get
        {
            if (_area != 0) return _area;
            double halfPerimeter = (SideA + SideB + SideC) / 2;
            _area = Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
            return _area;
        }
    }

    private double _sideA;
    private double _sideB;
    private double _sideC;

    public double SideA {
        get
        {
            if (_sideA != 0) return _sideA;
            throw new ArgumentException("The A side was not set");
        }
        set
        {
            if (value > 0) _sideA = value;
            else
            {
                throw new ArgumentException("The A side must be greater than 0");
            }
        }
    }
    public double SideB {
        get
        {
            if (_sideA != 0) return _sideB;
            throw new ArgumentException("The A side was not set");
        }
        set
        {
            if (value > 0) _sideB = value;
            else
            {
                throw new ArgumentException("The B side must be greater than 0");
            }        
        }
    }
    public double SideC {
        get
        {
            if (_sideC != 0) return _sideC;
            throw new ArgumentException("The A side was not set");
        }
        set
        {
            if (value > 0) _sideC = value;
            else
            {
                throw new ArgumentException("The C side must be greater than 0");
            }        
        }
    }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
        if (!(sideA + sideB > sideC && sideA + sideC > sideB && sideC + sideB > sideA))
        {
            throw new ArgumentException("For a triangle to exist, the sum of the two sides of the triangle must " +
                                        "always be greater than the third side.");
        }
    }
    
}