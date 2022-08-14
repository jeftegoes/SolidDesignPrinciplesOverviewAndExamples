namespace WithViolation
{
    public class ReportImporter : IDataImporter
    {
        public string GetDataFromExcel()
        {
            return "Report from Excel.";
        }

        public string GetDataFromPdf()
        {
            return "Report from Pdf.";
        }
    }
}