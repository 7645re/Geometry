namespace GeometryLib;

public class Triangle : IFigure
{
    public int A { get; }
    public int B { get; }
    public int C { get; }

    public bool IsRightTriangle
    {
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

    public static bool TryCreate(int a, int b, int c, out Triangle? circle)
    {
        // Стороны треугольника должны быть больше 0
        if (!(a > 0 && b > 0 && c > 0))
        {
            circle = null;
            return false;
        }

        // Треугольник существует, если сумма двух его сторон меньше третьей
        if (!(a + b > c && a + c > b && c + b > a))
        {
            circle = null;
            return false;
        }

        circle = new Triangle(a, b, c);
        return true;
    }

    private Triangle(int a, int b, int c)
    {
        A = a;
        B = b;
        C = c;
    }
}