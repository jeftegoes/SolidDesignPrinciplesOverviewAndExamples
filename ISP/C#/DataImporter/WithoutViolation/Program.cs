using WithoutViolation;

var reportImporter = new ReportImporter();
Console.WriteLine(reportImporter.GetDataFromPdf());
Console.WriteLine(reportImporter.GetDataFromExcel());

var tableImporter = new TableImporter();
Console.WriteLine(tableImporter.GetDataFromExcel());