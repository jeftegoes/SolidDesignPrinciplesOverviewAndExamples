namespace WithViolation
{
    public class Square
    {
        private readonly double _width;

        public Square(double width)
        {
            _width = width;
        }

        internal double GetWidth()
        {
            return _width;
        }
    }
}