using WithViolation;

var reportImporter = new ReportDatabaseImporter();
var reportPresenter = new ReportPresenter(reportImporter);
reportPresenter.ShowReport();