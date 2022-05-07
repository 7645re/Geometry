namespace GeometryLib.Interfaces;

public interface ITriangle : IFigure<ITriangle>
{
    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }
    public bool IsRightTriangle { get;}
}