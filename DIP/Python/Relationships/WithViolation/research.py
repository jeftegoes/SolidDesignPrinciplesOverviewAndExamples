from relationship import Relationship
from relationships import Relationships


class Research:
    def __init__(self, relationsships: Relationships) -> None:
        relations = relationsships.relations
        for relation in relations:
            if relation[0].name == "Jefté" and relation[1] == Relationship.PARENT:
                print(f"Jefté has a child called {relation[2].name}")
