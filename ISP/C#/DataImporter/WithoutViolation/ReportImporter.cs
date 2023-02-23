namespace WithoutViolation
{
    public class ReportImporter : IExcelParse, IPdfParse
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