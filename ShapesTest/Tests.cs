using Shapes;

namespace ShapesTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Circle_CalculateArea_ReturnsCorrectArea()
    {
        double radius = 5.0;
        IShape circle = new Circle(radius);
        double expectedArea = Math.PI * radius * radius;

        double actualArea = circle.CalculateArea();

        Assert.That(actualArea, Is.EqualTo(expectedArea));
    }
    
    [Test]
    public void Circle_CalculateArea_ThrowsExceptionForNegativeRadius()
    {
        double radius = -5.0;

        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }

    [Test]
    public void Circle_CalculateArea_ThrowsExceptionForZeroRadius()
    {
        double radius = 0;

        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }

    [Test]
    public void Triangle_CalculateArea_ReturnsCorrectArea()
    {
        
        double side1 = 3.0;
        double side2 = 4.0;
        double side3 = 5.0;

        IShape triangle = new Triangle(side1, side2, side3);

        double expectedArea = 6.0;
        double actualArea = triangle.CalculateArea();

        Assert.That(actualArea, Is.EqualTo(expectedArea));
    }
    
    [Test]
    public void Triangle_IsRightAngled_ReturnsTrueForRightAngledTriangle()
    {
        double side1 = 3.0;
        double side2 = 4.0;
        double side3 = 5.0;
        Triangle triangle = new Triangle(side1, side2, side3);

        bool isRightAngled = triangle.IsRightAngled();

        Assert.That(isRightAngled, Is.True);
    }
    
    [Test]
    public void Triangle_IsRightAngled_ReturnsFalseForNonRightAngledTriangle()
    {
        double side1 = 2.0;
        double side2 = 3.0;
        double side3 = 4.0;
        Triangle triangle = new Triangle(side1, side2, side3);

        bool isRightAngled = triangle.IsRightAngled();

        Assert.That(isRightAngled, Is.False);
    }
    
    [Test]
    public void Triangle_CalculateArea_ThrowsExceptionForInvalidSides()
    {
        double side1 = 2.0;
        double side2 = 3.0;
        double side3 = 10.0;

        Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
    }
    
    [Test]
    public void Triangle_CalculateArea_ThrowsExceptionForNegativeSide()
    {
        double side1 = -2.0;
        double side2 = 3.0;
        double side3 = 2.0;

        Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
    }
    
    [Test]
    public void Triangle_CalculateArea_ThrowsExceptionForZeroSide()
    {
        double side1 = 0;
        double side2 = 0;
        double side3 = 0;

        Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
    }
}