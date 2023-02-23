namespace WithoutViolation
{
    public class CardReadersCommunicatorViewModel
    {
        private readonly IReadersCommunicable _readersCommunicable;

        public CardReadersCommunicatorViewModel(IReadersCommunicable readersCommunicable)
        {
            _readersCommunicable = readersCommunicable;
        }

        public bool TestContactReaderOnPort(string port)
        {
            return _readersCommunicable.IsContactReaderOnPort(port);
        }

        public bool TestNonContactReaderOnPort(string port)
        {
            return _readersCommunicable.IsNonContactReaderOnPort(port);
        }

        public string FindContactReader()
        {
            return _readersCommunicable.FindContactReader();
        }
    }
}