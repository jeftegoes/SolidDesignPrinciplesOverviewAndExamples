from rectangle import Rectangle
from square import Square


def use_it(rectangle):
    width = rectangle.width
    rectangle.height = 10
    expected = int(width * 10)
    print(f'Expected an area of {expected}, got {rectangle.area}')


rectangle = Rectangle(2, 3)
use_it(rectangle)

square = Square(5)
use_it(square)
