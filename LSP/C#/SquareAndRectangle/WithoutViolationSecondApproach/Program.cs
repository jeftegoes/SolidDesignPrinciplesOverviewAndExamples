using WithoutViolationSecondApproach;

IShape rectangle = new Rectangle(2, 3);
Console.WriteLine($"{rectangle} has area {rectangle.CalculateArea()}");

IShape square = new Square(10);
Console.WriteLine($"{square} has area {square.CalculateArea()}");