namespace WithoutViolation
{
    public class Square : IShape
    {
        private readonly double _width;

        public Square(double width)
        {
            _width = width;
        }

        public double GetArea()
        {
            return _width * _width;
        }
    }
}