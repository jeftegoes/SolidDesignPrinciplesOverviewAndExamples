namespace WithViolation
{
    public interface IDataImporter
    {
         string GetDataFromExcel();
         string GetDataFromPdf();
    }
}