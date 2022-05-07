using System.Reflection.Metadata.Ecma335;
using GeometryLib.Interfaces;

namespace GeometryLib;

public class Triangle : ITriangle
{
    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }
    public bool IsRightTriangle {
        get
        {
            int h = Math.Max(A, Math.Max(B, C));
            return 2 * h * h == A * A + B * B + C * C;
        }
    }
    public double Area
    {
        get
        {
            double hPer = (A + B + C) / 2;
            return Math.Sqrt(hPer * (hPer - A) * (hPer - B) * (hPer - C));
        }
    }

    public static Triangle? TryCreate(int a, int b, int c)
    {
        // Стороны треугольника должны быть больше 0
        if (!(a > 0 && b > 0 && c > 0)) return null;
        // Треугольник существует, если сумма двух его сторон меньше третьей
        if (!(a + b > c && a + c > b && c + b > a)) return null;
        return new Triangle(a, b, c);
    }

    private Triangle(int a, int b, int c)
    {
        A = a;
        B = b;
        C = c;
    }
}