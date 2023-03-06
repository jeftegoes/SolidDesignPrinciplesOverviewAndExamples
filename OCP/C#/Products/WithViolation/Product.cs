namespace WithViolation
{
    public class Product
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }

        public Product(string name, Color color, Size size)
        {
            this.Name = name;
            this.Color = color;
            this.Size = size;
        }
    }
}