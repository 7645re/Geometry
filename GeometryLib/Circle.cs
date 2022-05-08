namespace GeometryLib;

public class Circle : IFigure
{
    public double Radius { get; }
    public double Area => Math.PI * Math.Pow(Radius, 2);

    public static bool TryCreate(double radius, out Circle? circle)
    {
        // Окружность существует, если радиус больше 0 (При нуле это просто точка и площади у нее нет)
        if (radius <= 0)
        {
            circle = null;
            return false;
        }

        circle = new Circle(radius);
        return true;
    }

    private Circle(double radius)
    {
        Radius = radius;
    }
}