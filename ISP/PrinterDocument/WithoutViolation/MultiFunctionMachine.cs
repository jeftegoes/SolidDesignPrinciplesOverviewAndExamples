namespace WithoutViolation
{
    public class MultiFunctionMachine : IMultiFuncionDevice
    {
        private readonly IPrinter _printer;
        private readonly IScanner _scanner;

        public MultiFunctionMachine(IPrinter printer, IScanner scanner)
        {
            _scanner = scanner;
            _printer = printer;
        }

        public void Print(Document document)
        {
            _printer.Print(document);
        }

        public void Scan(Document document)
        {
            _scanner.Scan(document);
        }
    }
}