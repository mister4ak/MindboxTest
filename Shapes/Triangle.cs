namespace Shapes
{
    public class Triangle : IShape
    {
        private const double Epsilon = 0.0001;
        
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("Triangle sides must be greater than zero.");

            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
                throw new ArgumentException("Invalid triangle sides. The sum of any two sides must be greater than the third side.");

            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double CalculateArea()
        {
            double semiperimeter = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - _side1) * (semiperimeter - _side2) * (semiperimeter - _side3));
        }

        public bool IsRightAngled()
        {
            double[] sides = { _side1, _side2, _side3 };
            Array.Sort(sides);

            double firstCathet = sides[0];
            double secondCathet = sides[1];
            double hypotenuse = sides[2];
            
            return Math.Abs(Math.Pow(hypotenuse, 2.0) - (Math.Pow(firstCathet, 2.0) + Math.Pow(secondCathet, 2.0))) < Epsilon;
        }
    }
}