from journal import Journal


class PersistenceManager:
    def __init__(self, journal: Journal) -> None:
        self.journal = journal

    def save_to_file(self, filename: str) -> None:
        file = open(filename, "w")
        file.write(str(self.journal))
        file.close()

    def load(self, filename: str) -> None:
        pass

    def low_from_web(self, uri: str) -> None:
        pass
