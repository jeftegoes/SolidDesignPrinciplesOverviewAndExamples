from abc import abstractmethod

from printer import Printer
from scanner import Scanner


class MultiFunctionDevice(Printer, Scanner):
    @abstractmethod
    def print(self, document):
        pass

    @abstractmethod
    def scan(self, document):
        pass
