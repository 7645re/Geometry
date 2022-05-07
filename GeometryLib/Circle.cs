using GeometryLib.Interfaces;

namespace GeometryLib;
// Сначала при попытке создания экземпляра класса с недопустимыми данными я выкидывал экзепшен, но подумав решил, 
// что это будет неудобно использовать и поэтому решил сделать через статический метод TryCreate
public class Circle : ICircle
{
    public double Radius { get; set; }
    public double Area => Math.PI * Math.Pow(Radius, 2);
    public static Circle? TryCreate(double radius) => radius <= 0 ? null : new Circle(radius);
    private Circle(double radius)
    {
        Radius = radius;
    }
}