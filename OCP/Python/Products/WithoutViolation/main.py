from better_filter import BetterFilter
from color import Color
from color_specification import ColorSpecification
from product import Product
from size import Size
from size_specification import SizeSpecification

apple = Product('Apple', Color.GREEN, Size.SMALL)
tree = Product('Tree', Color.GREEN, Size.LARGE)
house = Product('House', Color.BLUE, Size.LARGE)

products = [apple, tree, house]

better_filter = BetterFilter()
print('Green products (new):')
green = ColorSpecification(Color.GREEN)
for p in better_filter.filter(products, green):
    print(f' - {p.name} is green')

print('Large products:')
large = SizeSpecification(Size.LARGE)
for p in better_filter.filter(products, large):
    print(f' - {p.name} is large')

print('Large blue items:')

large_blue = large & ColorSpecification(Color.BLUE)
for p in better_filter.filter(products, large_blue):
    print(f' - {p.name} is large and blue')
