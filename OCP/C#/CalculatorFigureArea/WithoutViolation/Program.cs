using System.Diagnostics;
using WithoutViolation;

var figures = new List<IShape>()
{
    new Square(5)
};

var areaCalculator = new AreaCalculator(figures).Calculate();

Console.WriteLine("Square: {0}", areaCalculator);

Debug.Assert(areaCalculator == 25);

var figures2 = new List<IShape>()
{
    new Square(5),
    new Rectangle(5, 3)
};

var areaCalculator2 = new AreaCalculator(figures2).Calculate();

Console.WriteLine("Rectangle: {0}", areaCalculator2);

Debug.Assert(areaCalculator2 == 25 + 15);

var figures3 = new List<IShape>()
{
    new Square(5),
    new Rectangle(5, 3),
    new Circle(5)
};

var areaCalculator3 = new AreaCalculator(figures3).Calculate();

Console.WriteLine("Circle: {0}", areaCalculator3);

Debug.Assert(areaCalculator3 == (25 + 15 + Math.PI * 25));