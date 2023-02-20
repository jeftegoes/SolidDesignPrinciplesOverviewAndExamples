namespace WithViolation
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

        public void PrintBook()
        {
            Console.WriteLine(_title);
            Console.WriteLine(_content);
        }
    }
}