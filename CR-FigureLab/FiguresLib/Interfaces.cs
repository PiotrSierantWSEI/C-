using FiguresLib;

public interface IMeasurable1D
{
    double Length {get; }
}

public interface IMeasurable2D : IMeasurable1D
{
    double Circumference { get; }
    double Surface { get; }
}

public interface IMoveable
{
    void Move(Vector v);
}