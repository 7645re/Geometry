namespace GeometryLib.Interfaces;

public interface ITriangle : IFigure
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }
    public bool IsRightTriangle { get;}
}