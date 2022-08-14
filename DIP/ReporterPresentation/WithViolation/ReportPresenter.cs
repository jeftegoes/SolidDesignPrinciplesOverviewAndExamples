namespace WithViolation
{
    public class ReportPresenter
    {
        private readonly ReportDatabaseImporter _importer;

        public ReportPresenter(ReportDatabaseImporter importer)
        {
            _importer = importer;
        }

        public void ShowReport()
        {
            Console.WriteLine(_importer.GetReportData());
        }
    }
}