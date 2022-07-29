namespace WithViolation
{
    public class PdqTerminal : IBankTerminal
    {
        public event EventHandler<PaymentOperationCompletedEventArgs> PaymentCompleted;
        public event EventHandler<PaymentOperationCompletedEventArgs> CancellationCompleted;
        public event EventHandler<TransactionCompletedEventArgs> TransactionCompleted;

        public void BankHostTest()
        {
            throw new NotImplementedException();
        }

        public void CancelPayment(string checkId, decimal amount)
        {
            throw new NotImplementedException();
        }

        public void InterruptTransaction()
        {
            throw new NotImplementedException();
        }

        public void Ping()
        {
            throw new NotImplementedException();
        }

        public void Purchase(decimal amount, string checkId)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}