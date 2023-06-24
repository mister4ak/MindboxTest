using Shapes;

IShape circle = new Circle(5.0);
double circleArea = circle.CalculateArea();
Console.WriteLine($"Circle area: {circleArea}");

IShape triangle = new Triangle(3.0, 4.0, 5.0);
double triangleArea = triangle.CalculateArea();
Console.WriteLine($"Triangle area: {triangleArea}");