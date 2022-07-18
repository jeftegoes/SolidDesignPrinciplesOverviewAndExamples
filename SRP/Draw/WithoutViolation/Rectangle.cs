namespace WithoutViolation
{
    public class Rectangle : Shape
    {
        public static Rectangle GetRectangle()
        {
            return new Rectangle();
        }
    }
}