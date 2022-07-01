namespace ExampleSrp
{
    public class PosTerminalPayment : PaymentModel, ICanOperateWithCash
    {
        private readonly Action _onPayChangeToMobilePhone;
        private readonly TicketDetails _ticketDetails;
        private decimal _cashAccepted;

        public PosTerminalPayment(TicketDetails ticketDetails, Action onPayChangeToMobilePhone) : base(ticketDetails)
        {
            _ticketDetails = ticketDetails;
            _onPayChangeToMobilePhone = onPayChangeToMobilePhone;
        }

        public override void BuyTicket()
        {
            AcceptCash();
            DispenseChange();
        }

        public void AcceptCash()
        {
            var r = new Random();
            _cashAccepted = r.Next((int)_ticketDetails.Price, (int)_ticketDetails.Price + 1000);
        }

        public void DispenseChange()
        {
            if (_cashAccepted > _ticketDetails.Price && !TryToDispense(_cashAccepted - _ticketDetails.Price))
                _onPayChangeToMobilePhone?.Invoke();
        }

        private bool TryToDispense(decimal changeAmount)
        {
            return false; // Or true...
        }
    }
}