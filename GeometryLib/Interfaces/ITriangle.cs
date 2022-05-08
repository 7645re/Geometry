namespace GeometryLib.Interfaces;

public interface ITriangle : IFigure<ITriangle>
{
    public int A { get; }
    public int B { get; }
    public int C { get; }
    public bool IsRightTriangle { get; }
}