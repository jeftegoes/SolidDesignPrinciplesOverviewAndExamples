from abc import ABC, abstractmethod


class Printer(ABC):
    @abstractmethod
    def print(self, document): pass
