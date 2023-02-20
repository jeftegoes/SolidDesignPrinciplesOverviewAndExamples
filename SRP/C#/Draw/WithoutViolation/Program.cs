using WithoutViolation;

var rectangle = Rectangle.GetRectangle();
IShapeOperations shapeOperations = new ShapeOperations();
Color color = Colors.Red;
shapeOperations.Fill(rectangle, color);