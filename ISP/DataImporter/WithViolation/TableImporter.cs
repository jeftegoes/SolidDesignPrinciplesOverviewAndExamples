namespace WithViolation
{
    public class TableImporter : IDataImporter
    {
        public string GetDataFromExcel()
        {
            return "Table from Excel.";
        }

        public string GetDataFromPdf()
        {
            // We don't return a table from pdf file, this isn't responsibility of this class.
            return string.Empty;
        }
    }
}