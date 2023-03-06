namespace WithoutViolation
{
    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.Pow(_radius, 2) * Math.PI;
        }
    }
}