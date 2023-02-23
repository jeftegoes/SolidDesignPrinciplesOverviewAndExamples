from abc import abstractmethod


class RelationshipBrowser:
    @abstractmethod
    def find_all_children_of(self, name):
        pass
