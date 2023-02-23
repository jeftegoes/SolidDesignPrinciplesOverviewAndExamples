namespace WithoutViolation
{
    public class ReportDatabaseImporter : IReportImporter
    {
        public IReportData GetReportData()
        {
            return new ReportData("Report from Database.");
        }
    }
}