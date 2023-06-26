namespace Shapes;

public class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be greater than zero.", nameof(radius));

        _radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(_radius, 2.0);
    }
}