from abc import ABC, abstractmethod


class Scanner(ABC):
    @abstractmethod
    def scan(self, document): pass
