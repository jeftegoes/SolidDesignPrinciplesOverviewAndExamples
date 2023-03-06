namespace WithViolation
{
    public class AreaCalculator
    {
        private readonly List<object> figures;

        public AreaCalculator(List<object> figures)
        {
            this.figures = figures;
        }

        public double Calculate()
        {
            var area = 0d;
            
            foreach (var figure in figures)
            {
                switch (figure)
                {
                    case Square square:
                        area += square.GetWidth() * square.GetWidth();
                        break;
                    case Rectangle rectangle:
                        area += rectangle.GetWidth() * rectangle.GetHeight();
                        break;
                    case Circle circle:
                        area += Math.Pow(circle.GetRadius(), 2) * Math.PI;
                        break;
                    default:
                        area += area;
                        break;
                }
            }

            return area;
        }
    }
}