from color import Color
from product import Product
from size import Size


class ProductFilter:
    def filter_by_color(self, products: list[Product], color: Color) -> Product:
        for product in products:
            if product.color == color:
                yield product

    def filter_by_size(self, products: list[Product], size: Size) -> Product:
        for product in products:
            if product.size == size:
                yield product

    def filter_by_size_and_color(self, products: list[Product], size: Size, color: Color) -> Product:
        for product in products:
            if product.size == size and product.color == color:
                yield product