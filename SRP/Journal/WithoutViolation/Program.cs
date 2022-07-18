using WithoutViolation;

var journal = new Journal();
journal.AddEntry("I cried today");
journal.AddEntry("I ate a bug");
Console.WriteLine(journal);

var persistence = new Persistence();
persistence.SaveToFile(journal, "journal.txt", true);