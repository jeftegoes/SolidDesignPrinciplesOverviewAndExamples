namespace WithViolation
{
    public interface IBankTerminal
    {
        void Start();
        void Stop();
        void Ping();
        void BankHostTest();
        void Purchase(decimal amount, string checkId);
        void CancelPayment(string checkId, decimal amount);
        void InterruptTransaction();
        bool IsContactReaderOnPort(string comPort);
        bool IsNonContactReaderOnPort(string comPort);
        string FindContactReader();
        string FindNonContactReader();

        event EventHandler<PaymentOperationCompletedEventArgs> PaymentCompleted;
        event EventHandler<PaymentOperationCompletedEventArgs> CancellationCompleted;
        event EventHandler<TransactionCompletedEventArgs> TransactionCompleted;
    }
}