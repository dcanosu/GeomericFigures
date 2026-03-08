namespace GeometricFigures.Backend;

public class Circle : GeometricFigure
{
    private double _r;

    public Circle(string name, double r) : base(name)
    {
        R = r;
    }
    public double R { 
        get => _r;
        set => _r = validateR(value); 
    }

    public override double GetArea() => Math.PI * Math.Pow(R, 2);
    public override double GetPerimiter() => 2 * Math.PI * R;

    private double validateR(double r)
    {
        if (r <= 0)
            throw new System.ArgumentOutOfRangeException(nameof(r), "Radius must be greater than zero.");
        return r;
    }
}