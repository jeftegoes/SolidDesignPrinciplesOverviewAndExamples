from person import Person
from relationship import Relationship


class Relationships:
    def __init__(self) -> None:
        self.relations: list[tuple()] = []

    def add_parent_and_child(self, parent: Person, child: Person):
        self.relations.append((parent, Relationship.PARENT, child))
        self.relations.append((child, Relationship.CHILD, parent))
