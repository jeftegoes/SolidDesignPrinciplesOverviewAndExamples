using WithViolation;

var apple = new Product("Apple", Color.Green, Size.Small);
var tree = new Product("Tree", Color.Green, Size.Large);
var house = new Product("House", Color.Blue, Size.Large);

Product[] products = { apple, tree, house };

var productFilter = new ProductFilter();
Console.WriteLine("Green products (old): {0}");
foreach (var product in productFilter.FilterByColor(products, Color.Green))
{
    Console.WriteLine($" - {product.Name} is green.");
}