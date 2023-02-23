from person import Person
from relationship import Relationship
from relationship_browser import RelationshipBrowser


class Relationships(RelationshipBrowser):
    def __init__(self) -> None:
        self.relations: list[tuple()] = []

    def add_parent_and_child(self, parent: Person, child: Person):
        self.relations.append((parent, Relationship.PARENT, child))
        self.relations.append((child, Relationship.CHILD, parent))

    def find_all_children_of(self, name) -> list[str]:
        for relation in self.relations:
            if relation[0].name == name and relation[1] == Relationship.PARENT:
                yield relation[2].name
