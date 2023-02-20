namespace WithoutViolation
{
    public class ShapeOperations : IShapeOperations
    {
        public void Fill(Shape shape, Color color)
        {
            shape.Color = color;
        }
    }
}