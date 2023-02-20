from journal import Journal
from persistence_manager import PersistenceManager

journal = Journal()
journal.add_entry("I cried today.")
journal.add_entry("I ate a bug.")
print(f"Journal entries:\n{journal}")

persistence = PersistenceManager(journal)
file = "journal.txt"
persistence.save_to_file(file)

with open(file) as fh:
    print(fh.read())
