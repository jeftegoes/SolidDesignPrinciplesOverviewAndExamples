namespace WithoutViolation
{
    public class AreaCalculator
    {
        private readonly List<IShape> _shapes;

        public AreaCalculator(List<IShape> shapes)
        {
            _shapes = shapes;
        }

        public double Calculate()
        {
            return _shapes.Sum(c => c.GetArea());
        }
    }
}