from color import Color
from specification import Specification


class ColorSpecification(Specification):
    def __init__(self, color: Color):
        self.color = color

    def is_satisfied(self, item):
        return item.color == self.color