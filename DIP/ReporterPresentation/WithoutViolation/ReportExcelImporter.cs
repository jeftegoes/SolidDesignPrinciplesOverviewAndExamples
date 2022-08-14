namespace WithoutViolation
{
    public class ReportExcelImporter : IReportImporter
    {
        public IReportData GetReportData()
        {
            return new ReportData("Report from Excel.");
        }
    }
}