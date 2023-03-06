namespace WithViolation
{
    public class Rectangle
    {
        private readonly double _width;
        private readonly double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        internal double GetWidth()
        {
            return _width;
        }

        internal double GetHeight()
        {
            return _height;
        }
    }
}