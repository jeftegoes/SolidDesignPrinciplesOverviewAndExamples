using System;
using System.Runtime.InteropServices;

namespace WithoutViolation
{
    public class ZapTerminal : IBankTerminal, IReadersCommunicable
    {
        public event EventHandler<PaymentOperationCompletedEventArgs> PaymentCompleted;
        public event EventHandler<PaymentOperationCompletedEventArgs> CancellationCompleted;
        public event EventHandler<TransactionCompletedEventArgs> TransactionCompleted;
        private PdqTerminalServiceCommunicator _service = new PdqTerminalServiceCommunicator();

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

        public string FindContactReader()
        {
            return _service.FindContactReader();
        }

        public string FindNonContactReader()
        {
            return _service.FindNonContactReader();
        }

        public bool IsContactReaderOnPort(string comPort)
        {
            return _service.IsContactReaderOnPort(comPort);
        }

        public bool IsNonContactReaderOnPort(string comPort)
        {
            return _service.IsNonContactReaderOnPort(comPort);
        }
    }
}