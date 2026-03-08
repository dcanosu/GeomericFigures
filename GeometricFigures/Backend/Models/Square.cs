namespace GeometricFigures.Backend;

public class Square : GeometricFigure
{
    private double _a;

    public Square(string name, double a) : base(name)
    {
        A = a;
    }

    public double A
    {
        get => _a;
        set => _a = validateA(value);
    }
    public override double GetArea() => A * A;
    public override double GetPerimiter() => 4 * A;
    private double validateA(double a)
    {
        if (a <= 0)
            throw new System.ArgumentOutOfRangeException(nameof(a), "Side length must be greater than zero.");
        return a;
    }
}