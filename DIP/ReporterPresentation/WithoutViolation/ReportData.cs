namespace WithoutViolation
{
    public class ReportData : IReportData
    {
        private readonly string _content;

        public ReportData(string content)
        {
            _content = content;
        }

        public string GetContent()
        {
            return _content;
        }
    }
}