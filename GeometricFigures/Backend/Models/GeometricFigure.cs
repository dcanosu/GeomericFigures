namespace GeometricFigures.Backend;

public abstract class GeometricFigure
{
    protected GeometricFigure(string name)
    {
        Name = name;
    }
    public string Name { get; set; }

    public abstract double GetArea();

    public abstract double GetPerimiter();

    public override string ToString()
    {
        return $"{Name,-15} => Area.....: {GetArea(),12:N5}    Perimeter: {GetPerimiter(),12:N5}";
    }

}
