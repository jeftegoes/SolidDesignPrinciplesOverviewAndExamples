using WithoutViolation;

var book = new Book("Interessting title", "Nice content");

IPrinter printer = new BookPrinter();

printer.Print(book.GetBookToPrint());