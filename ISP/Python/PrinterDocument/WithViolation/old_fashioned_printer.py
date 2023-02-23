from machine import Machine


class OldFashionedPrinter(Machine):
    def print(self, document):
        pass

    def fax(self, document):
        pass

    def scan(self, document):
        """Not supported!"""
        raise NotImplementedError('Printer cannot scan!')
