namespace GeometricFigures.Backend;

public class Triangle : Rectangle
{
    private double _c;
    private double _h;
    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b){ 
        C = c; 
        H = h; 
    }
    public double C { 
        get => _c;
        set => _c = validateC(value); 
    }
    public double H { 
        get => _h;
        set => _h = validateH(value); 
    }

    public override double GetArea() => (B * H) / 2;
    public override double GetPerimiter() => A + B + C;

    private double validateC(double c)
    {
        if (c <= 0)
            throw new System.ArgumentOutOfRangeException(nameof(c), "Side length must be greater than zero.");
        return c;
    }

    private double validateH(double h)
    {
        if (h <= 0)
            throw new System.ArgumentOutOfRangeException(nameof(h), "Height must be greater than zero.");
        return h;
    }
}