using WithViolation;

Func<Rectangle, int> area = (r) => r.Height * r.Width;

Rectangle rectangle = new Rectangle(2, 3);
Console.WriteLine($"{rectangle} has area {area(rectangle)}");

Rectangle square = new Square();
square.Width = 4;
Console.WriteLine($"{square} has area {area(square)}");