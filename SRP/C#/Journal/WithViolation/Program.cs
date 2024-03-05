using WithViolation;

var journal = new Journal();
journal.AddEntry("I cried today.");
journal.AddEntry("I ate a bug.");
Console.WriteLine(journal);

journal.SaveToFile(journal, "journal.txt", true);