class Journal:
    def __init__(self) -> None:
        self.entries: list(str) = []
        self.count: int = 0

    def add_entry(self, text: str) -> None:
        self.count += 1
        self.entries.append(f"{self.count}: {text}")

    def remove_entry(self, pos: int) -> None:
        del self.entries[pos]

    def __str__(self) -> str:
        return "\n".join(self.entries)
