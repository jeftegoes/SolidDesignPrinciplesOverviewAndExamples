using WithoutViolation;

var reportDatabaseImporter = new ReportDatabaseImporter();
var reportPresenter = new ReportPresenter(reportDatabaseImporter);
reportPresenter.ShowReport();

var reportDatabaseExcel = new ReportExcelImporter();
var reportPresenter2 = new ReportPresenter(reportDatabaseExcel);
reportPresenter2.ShowReport();