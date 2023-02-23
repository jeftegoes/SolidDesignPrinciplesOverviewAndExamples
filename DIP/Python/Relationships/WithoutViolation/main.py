from person import Person
from relationships import Relationships
from research import Research

parent = Person("Jefté")
child1 = Person("Brenno")
child2 = Person("Brunno")

relationships = Relationships()
relationships.add_parent_and_child(parent, child1)
relationships.add_parent_and_child(parent, child2)

Research(relationships)
