namespace GeometricFigures.Backend;

public class Rhombus : Square
{
    private double _d1;
    private double _d2;
    public Rhombus(string name, double a, double d1, double d2) : base(name, a)
    {
        D1 = d1;
        D2 = d2;
    }
    public double D1
    {
        get => _d1;
        set => _d1 = validateD1(value);
    }
    public double D2
    {
        get => _d2;
        set => _d2 = validateD2(value);
    }
    public override double GetArea() => (D1 * D2) / 2;

    public override double GetPerimiter() => 4 * A;

    private double validateD1(double d)
    {
        if (d <= 0)
            throw new System.ArgumentOutOfRangeException(nameof(d), "Diagonal length must be greater than zero.");
        return d;
    }

    private double validateD2(double d)
    {
        if (d <= 0)
            throw new System.ArgumentOutOfRangeException(nameof(d), "Diagonal length must be greater than zero.");
        return d;
    }
}