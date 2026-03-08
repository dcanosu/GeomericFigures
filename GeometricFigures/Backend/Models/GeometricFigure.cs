namespace GeometricFigures.Backend;
public abstract class GeometricFigure
{
    protected GeometricFigure(string name)
    {
        Name = name;
    }
    public string Name { get; set; }

    // This is an abstract method that will be implemented by each specific figure to calculate its area.
    public abstract double GetArea();

    // This is an abstract method that will be implemented by each specific figure to calculate its perimeter.
    public abstract double GetPerimiter();

    public override string ToString()
    {
        return $"{Name,-15} => Area.....: {GetArea(),12:N5}    Perimeter: {GetPerimiter(),12:N5}";
    }  

}
