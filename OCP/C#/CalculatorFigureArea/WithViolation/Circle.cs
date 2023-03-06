namespace WithViolation
{
    public class Circle
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        internal double GetRadius()
        {
            return _radius;
        }
    }
}