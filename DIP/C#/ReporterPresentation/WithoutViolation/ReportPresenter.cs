namespace WithoutViolation
{
    public class ReportPresenter : IReportPresenter
    {
        private readonly IReportImporter _importer;

        public ReportPresenter(IReportImporter importer)
        {
            _importer = importer;
        }

        public void ShowReport()
        {
            var reportData = _importer.GetReportData();
            Console.WriteLine(reportData.GetContent());
        }
    }
}