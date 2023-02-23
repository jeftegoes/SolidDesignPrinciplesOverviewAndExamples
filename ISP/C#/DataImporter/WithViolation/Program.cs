using WithViolation;

IDataImporter reportImporter = new ReportImporter();
Console.WriteLine(reportImporter.GetDataFromPdf());
Console.WriteLine(reportImporter.GetDataFromExcel());

IDataImporter tableImporter = new TableImporter();
Console.WriteLine(tableImporter.GetDataFromPdf());
Console.WriteLine(tableImporter.GetDataFromExcel());