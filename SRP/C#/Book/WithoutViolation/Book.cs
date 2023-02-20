namespace WithoutViolation
{
    public class Book
    {
        private string _title;
        private string _content;

        public Book(string title, string content)
        {
            _title = title;
            _content = content;
        }

        public string GetBookToPrint()
        {
            return $"Title: {_title}{Environment.NewLine}Content: {_content}";
        }
    }
}