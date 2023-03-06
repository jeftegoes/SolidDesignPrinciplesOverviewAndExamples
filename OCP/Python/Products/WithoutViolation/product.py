from color import Color
from size import Size


class Product:
    def __init__(self, name: str, color: Color, size: Size) -> None:
        self.name = name
        self.color = color
        self.size = size