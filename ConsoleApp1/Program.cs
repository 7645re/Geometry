using GeometryLib;
using GeometryLib.Interfaces;

namespace ConsoleApp1;

internal static class Program
{
    public static void Main(string[] args)
    {
        IFigure figure1 = new Circle(10);
        Triangle figure2 = new Triangle(3,4,5);
        Console.WriteLine(figure2.IsRightTriangle);
    }
}