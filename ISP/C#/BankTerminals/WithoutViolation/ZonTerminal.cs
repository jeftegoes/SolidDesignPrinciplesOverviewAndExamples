namespace WithoutViolation
{
    public class ZonTerminal : IBankTerminal
    {
        public event EventHandler<PaymentOperationCompletedEventArgs> PaymentCompleted;
        public event EventHandler<PaymentOperationCompletedEventArgs> CancellationCompleted;
        public event EventHandler<TransactionCompletedEventArgs> TransactionCompleted;

        public void BankHostTest()
        {

        }

        public void CancelPayment(string checkId, decimal amount)
        {

        }

        public void InterruptTransaction()
        {

        }

        public void Ping()
        {

        }

        public void Purchase(decimal amount, string checkId)
        {

        }

        public void Start()
        {

        }

        public void Stop()
        {

        }
    }
}