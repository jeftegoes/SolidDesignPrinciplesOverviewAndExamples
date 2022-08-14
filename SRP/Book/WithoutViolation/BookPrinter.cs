namespace WithoutViolation
{
    public class BookPrinter : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine(content);
        }
    }
}