namespace WithViolation
{
    public class CardReadersCommunicatorViewModel
    {
        public CardReadersCommunicatorViewModel()
        {

        }

        public bool TestContactReaderOnPort(string port)
        {
            return false;
        }

        public bool TestNonContactReaderOnPort(string port)
        {
            return false;
        }

        public string FindContactReader()
        {
            return null;
        }
    }
}