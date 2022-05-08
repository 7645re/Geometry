namespace GeometryLib.Interfaces;

public interface ICircle : IFigure<ICircle>
{
    public double Radius { get; }
}