namespace WithViolation
{
    public class Draw
    {
        public void DrawRectangle()
        {
            Rectangle rect = RectangleOperations.GetRectangle();
            Color color = Colors.Red;
            rect.Fill(color);
        }
    }
}